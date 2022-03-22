namespace PLT_lab1_winform
{

    public partial class BuildForm : Form
    {
        bool leftSearch = true;
        int maxVT = 6, maxVN = 10;
        View view;
        internal BuildForm(View viewModel)
        {
            InitializeComponent();
            view = viewModel;
        }

        private void BuildForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            gramList.Items.AddRange(view.grams.Keys.ToArray());
            gramList.SelectedIndex = 0;

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
            //  label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            leftSearch = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            leftSearch = true;
        }

        private void gramList_SelectedIndexChanged(object sender, EventArgs e)
        {
            showGram.Nodes.Clear();
            lib.Gram gram = view.grams[gramList.Items[gramList.SelectedIndex].ToString()];
            gramList.Items[gramList.SelectedIndex].ToString();
            showGram.Nodes.Add("VT");
            foreach (lib.VT VT in gram.VT)
                showGram.Nodes[0].Nodes.Add(VT.name);
            showGram.Nodes.Add("VN");
            for (int i = 0; i < gram.VN.Count; i++)
            {
                lib.VN VN = gram.VN[i];
                showGram.Nodes[1].Nodes.Add(VN.name);
                if (VN == gram.StartVN) { showGram.Nodes[1].Nodes[i].ForeColor = Color.RoyalBlue; }
                //вывести правила
                foreach (lib.Chain ruleBlock in VN.Rules)
                {
                    showGram.Nodes[1].Nodes[i].Nodes.Add(ruleBlock.Print());
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            maxVT = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            maxVN = (int)numericUpDown2.Value;
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            showResults.Nodes.Clear();
            if (gramList.SelectedIndex == -1) { MessageBox.Show("выберите грамматику"); return; }
            lib.Gram gram = view.grams[gramList.Items[gramList.SelectedIndex].ToString()];
            List<lib.Chain> results = gram.BuildChains(leftSearch, maxVT, maxVN);
            for (int i = 0; i < results.Count; i++)
            {
                showResults.Nodes.Add(results[i].Print());
                for (int j = 0; j < results[i].chainHistory.Count; j++)
                {
                    string a = "";
                    for (int n = 0; n < results[i].chainHistory[j].ReplacedChain.chain.Count; n++)
                    {
                        if (results[i].chainHistory[j].ReplacedChain.chain[n] is lib.VN)
                        {
                            if (n == results[i].chainHistory[j].ReplacedSymbolIndex)
                                a += $"<*{results[i].chainHistory[j].ReplacedChain.chain[n].name}>";
                            else a += $"<{results[i].chainHistory[j].ReplacedChain.chain[n].name}>";
                        }
                        else a += results[i].chainHistory[j].ReplacedChain.chain[n].name;
                    }
                    a += " - ";
                    a += results[i].chainHistory[j].ReceivedChain.Print();
                    showResults.Nodes[i].Nodes.Add(a);
                }
            }
            label2.Text = $"Построено строк:{results.Count}";
        }
    }
}
