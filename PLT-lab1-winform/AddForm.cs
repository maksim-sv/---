using System.Text.RegularExpressions;

namespace PLT_lab1_winform
{
    public partial class AddForm : Form
    {
        readonly ContextMenuStrip contextMenu;
        ToolStripMenuItem delete, startVN, clearSelection;
        int selectedListbox = -1; // костыль
        internal View view;
        int startVNindex = -1;
        internal AddForm(View savedView)
        {
            view = savedView;
            InitializeComponent();
            contextMenu = new ContextMenuStrip();
            delete = new ToolStripMenuItem() { Text = "Удалить" };
            delete.Click += delete_Click;
            startVN = new ToolStripMenuItem() { Text = "Пометить как S" };
            startVN.Click += startVN_Click;
            clearSelection = new ToolStripMenuItem() { Text = "Снять выделение" };
            clearSelection.Click += clearSelection_Click;
            errorLabel.Text = "";
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            /*  if (view.VTList != null)
                  Add_VT_List.Items.AddRange(view.VTList);
              if (view.VNList != null)
                  Add_VN_List.Items.AddRange(view.VNList);
              if (view.RulesList != null)
                  Add_Rules_List.Items.AddRange(view.RulesList);*/
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            AddGramBtn.BackColor = ThemeColor.PrimaryColor;
            AddGramBtn.ForeColor = Color.White;
        }
        private void startVN_Click(object sender, EventArgs e)
        {
            setS(Add_VN_List.SelectedIndex);
        }
        private void clearSelection_Click(object sender, EventArgs e)
        {
            ListBox listBox = new();
            switch (selectedListbox)
            {
                case 0:
                    listBox = Add_VT_List;
                    break;
                case 1:
                    listBox = Add_VN_List;
                    break;
                case 2:
                    listBox = Add_Rules_List;
                    break;
            }
            listBox.SelectedItems.Clear();
        }

        private void ShowContextMenu(object sender, MouseEventArgs e)
        {
            if (selectedListbox == 1 & Add_VN_List.SelectedItems.Count == 1)
            {
                contextMenu.Items.Add(startVN);
            }
            contextMenu.Items.Add(delete);
            contextMenu.Items.Add(clearSelection);
            contextMenu.Show(Cursor.Position);
        }
        void setS(int index)
        {
            string s;
            if (startVNindex != -1)
            {
                s = Add_VN_List.Items[startVNindex].ToString();
                s = s.Remove(s.Length - 1);
                Add_VN_List.Items.RemoveAt(startVNindex);
                Add_VN_List.Items.Insert(startVNindex, s);
            }
            startVNindex = index;
            s = Add_VN_List.Items[index].ToString();
            s += '*';
            Add_VN_List.Items.RemoveAt(index);
            Add_VN_List.Items.Insert(index, s);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            ListBox listBox = new();
            switch (selectedListbox)
            {
                case 0:
                    listBox = Add_VT_List;
                    break;
                case 1:
                    listBox = Add_VN_List;
                    break;
                case 2:
                    listBox = Add_Rules_List;
                    break;
            }
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox);
            for (int i = selectedItems.Count - 1; i >= 0; i--)
                if (selectedListbox == 1 & i == startVNindex)
                {
                    listBox.Items.Remove(selectedItems[i]);
                    if (listBox.Items.Count == 0) { startVNindex = -1; }
                    else { setS(0); }
                }
                else
                {
                    listBox.Items.Remove(selectedItems[i]);
                }
        }


        private void Add_VT_Btn_Click(object sender, EventArgs e)
        {
            if (lib.GramChecker.CheckV(Add_VT_textbox.Text) == false)
                errorLabel.Text = "неправильный синтаксис VT";
            else
            {
                string a = Add_VT_textbox.Text;
                a = Regex.Replace(a, @"\s", "");
                string[] aArray = a.Split(',');
                foreach (string s in aArray)
                {
                    if (Add_VT_List.Items.Contains(s) == false)
                    { Add_VT_List.Items.Add(s); }
                }
                Add_VT_textbox.Text = "";
                errorLabel.Text = "";
                //  Add_VT_List.Items.Add();
            }
        }

        private void Add_VN_Button_Click(object sender, EventArgs e)
        {
            if (lib.GramChecker.CheckV(Add_VN_textbox.Text) == false)
                errorLabel.Text = "неправильный синтаксис VN";
            else
            {
                string a = Add_VN_textbox.Text;
                a = Regex.Replace(a, @"\s", "");
                string[] aArray = a.Split(',');
                foreach (string s in aArray)
                    if (Add_VN_List.Items.Count == 0) { Add_VN_List.Items.Add(s); setS(0); }
                    else if (Add_VN_List.Items.Contains(s) == false)
                        Add_VN_List.Items.Add(s);
                Add_VN_textbox.Text = "";
                errorLabel.Text = "";
            }
        }

        private void Add_Rules_Btn_Click(object sender, EventArgs e)
        {
            if (lib.GramChecker.CheckP(Add_Rules_textbox.Text) == false)
                errorLabel.Text = "неправильный синтаксис правил";
            else
            {
                string a = Add_Rules_textbox.Text;
                a = Regex.Replace(a, @"\s", "");
                Add_Rules_textbox.Text = "";
                errorLabel.Text = "";
                foreach (string s in Add_Rules_List.Items)
                    if (a == s)
                    {
                        return;
                    }
                Add_Rules_List.Items.Add(a);
            }
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            view.VTList = Add_VT_List.Items;
            view.VNList = Add_VN_List.Items;
            view.RulesList = Add_Rules_List.Items;
        }

        private void Add_VT_textbox_TextChanged(object sender, EventArgs e)
        {
            if (lib.GramChecker.CheckV(Add_VT_textbox.Text) == false)
                errorLabel.Text = "неправильный синтаксис VT";
            else
            {
                errorLabel.Text = "";

            }
        }

        private void Add_VN_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (lib.GramChecker.CheckV(Add_VN_textbox.Text) == false)
                errorLabel.Text = "неправильный синтаксис VN";
            else
            {
                errorLabel.Text = "";

            }
        }

        private void Add_Rules_textbox_TextChanged(object sender, EventArgs e)
        {
            if (lib.GramChecker.CheckP(Add_Rules_textbox.Text) == false)
                errorLabel.Text = "неправильный синтаксис правил";
            else
            {
                errorLabel.Text = "";
            }
        }



        private void AddGramBtn_Click(object sender, EventArgs e)
        {
            if (gramNameTextbox.Text == "") MessageBox.Show("введите имя грамматики");
            else
            {
                if (Add_VT_List.Items.Count == 0) { errorLabel.Text = "пустой алфавит VT"; return; }
                view.VTList = Add_VT_List.Items;
                if (Add_VN_List.Items.Count == 0) { errorLabel.Text = "пустой алфавит VN"; return; }
                {
                    view.VNList = new ListBox.ObjectCollection(new ListBox());
                    foreach (var item in Add_VN_List.Items)
                        view.VNList.Add(item);
                    string s = view.VNList[startVNindex].ToString();
                    s = s.Remove(s.Length - 1);
                    view.VNList.RemoveAt(startVNindex);
                    view.VNList.Insert(startVNindex, s);
                    view.S = view.VNList[startVNindex];
                }
                if (Add_Rules_List.Items.Count == 0) { errorLabel.Text = "нет правил"; return; }
                view.RulesList = Add_Rules_List.Items;
                try
                {
                    view.SaveGram(gramNameTextbox.Text);
                    errorLabel.Text = "грамматика добавлена";
                    errorLabel.ForeColor = Color.Green;
                    Add_VT_List.Items.Clear();
                    Add_VN_List.Items.Clear();
                    Add_Rules_List.Items.Clear();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                    setS(startVNindex);
                }
            }
        }

        private void Add_VT_List_MouseDown(object sender, MouseEventArgs e)
        {
            selectedListbox = 0;
            if (e.Button == MouseButtons.Right)
            {
                int index = -1;
                index = Add_VT_List.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                    ShowContextMenu(sender, e);
                else Add_VT_List.SelectedItems.Clear();
            }
        }
        private void Add_VN_List_MouseDown(object sender, MouseEventArgs e)
        {
            selectedListbox = 1;
            if (e.Button == MouseButtons.Right)
            {
                int index = -1;
                index = Add_VN_List.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                    ShowContextMenu(sender, e);
                else Add_VN_List.SelectedItems.Clear();
            }
        }
        private void Add_Rules_List_MouseDown(object sender, MouseEventArgs e)
        {
            selectedListbox = 2;
            if (e.Button == MouseButtons.Right)
            {
                int index = -1;
                index = Add_Rules_List.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                    ShowContextMenu(sender, e);
                else Add_Rules_List.SelectedItems.Clear();
            }
        }

        private void Add_VT_List_Leave(object sender, EventArgs e)
        {
            selectedListbox = -1;
            Add_VT_List.SelectedItems.Clear();
        }

        private void AddGramBtn_Leave(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            errorLabel.ForeColor = Color.Salmon;
        }

        private void Add_VN_List_Leave(object sender, EventArgs e)
        {
            selectedListbox = -1;
            Add_VN_List.SelectedItems.Clear();
        }

        private void Add_Rules_List_Leave(object sender, EventArgs e)
        {
            selectedListbox = -1;
            Add_Rules_List.SelectedItems.Clear();
        }
    }
}
