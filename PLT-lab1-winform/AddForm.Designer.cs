namespace PLT_lab1_winform
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_VN_Button = new System.Windows.Forms.Button();
            this.Add_VN_textbox = new System.Windows.Forms.TextBox();
            this.Add_VT_List = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gramNameTextbox = new System.Windows.Forms.TextBox();
            this.AddGramBtn = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.Bottom = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.Rules_Panel = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Add_Rules_textbox = new System.Windows.Forms.TextBox();
            this.Add_Rules_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VT_Panel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Add_VT_textbox = new System.Windows.Forms.TextBox();
            this.Add_VT_Btn = new System.Windows.Forms.Button();
            this.VT_Label = new System.Windows.Forms.Label();
            this.VN_Panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Add_VN_List = new System.Windows.Forms.ListBox();
            this.Add_Rules_List = new System.Windows.Forms.ListBox();
            this.ContentTable = new System.Windows.Forms.TableLayoutPanel();
            this.Bottom.SuspendLayout();
            this.Rules_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.VT_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.VN_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ContentTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "VN";
            // 
            // Add_VN_Button
            // 
            this.Add_VN_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_VN_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_VN_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_VN_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_VN_Button.Location = new System.Drawing.Point(0, 0);
            this.Add_VN_Button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_VN_Button.Name = "Add_VN_Button";
            this.Add_VN_Button.Size = new System.Drawing.Size(70, 23);
            this.Add_VN_Button.TabIndex = 28;
            this.Add_VN_Button.Text = "Добавить";
            this.Add_VN_Button.UseVisualStyleBackColor = true;
            this.Add_VN_Button.Click += new System.EventHandler(this.Add_VN_Button_Click);
            // 
            // Add_VN_textbox
            // 
            this.Add_VN_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_VN_textbox.Location = new System.Drawing.Point(0, 0);
            this.Add_VN_textbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_VN_textbox.Name = "Add_VN_textbox";
            this.Add_VN_textbox.PlaceholderText = "Г , Х";
            this.Add_VN_textbox.Size = new System.Drawing.Size(103, 23);
            this.Add_VN_textbox.TabIndex = 27;
            this.Add_VN_textbox.TextChanged += new System.EventHandler(this.Add_VN_Textbox_TextChanged);
            // 
            // Add_VT_List
            // 
            this.Add_VT_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_VT_List.FormattingEnabled = true;
            this.Add_VT_List.ItemHeight = 15;
            this.Add_VT_List.Location = new System.Drawing.Point(3, 47);
            this.Add_VT_List.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_VT_List.Name = "Add_VT_List";
            this.Add_VT_List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Add_VT_List.Size = new System.Drawing.Size(177, 238);
            this.Add_VT_List.TabIndex = 25;
            this.Add_VT_List.Leave += new System.EventHandler(this.Add_VT_List_Leave);
            this.Add_VT_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_VT_List_MouseDown);
            // 
            // gramNameTextbox
            // 
            this.gramNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gramNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gramNameTextbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gramNameTextbox.Location = new System.Drawing.Point(513, 4);
            this.gramNameTextbox.Name = "gramNameTextbox";
            this.gramNameTextbox.Size = new System.Drawing.Size(138, 23);
            this.gramNameTextbox.TabIndex = 38;
            // 
            // AddGramBtn
            // 
            this.AddGramBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddGramBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddGramBtn.FlatAppearance.BorderSize = 0;
            this.AddGramBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGramBtn.Location = new System.Drawing.Point(655, 3);
            this.AddGramBtn.Name = "AddGramBtn";
            this.AddGramBtn.Size = new System.Drawing.Size(75, 25);
            this.AddGramBtn.TabIndex = 39;
            this.AddGramBtn.Text = "Добавить";
            this.AddGramBtn.UseVisualStyleBackColor = false;
            this.AddGramBtn.Click += new System.EventHandler(this.AddGramBtn_Click);
            this.AddGramBtn.Leave += new System.EventHandler(this.AddGramBtn_Leave);
            // 
            // AddLabel
            // 
            this.AddLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLabel.AutoSize = true;
            this.AddLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddLabel.Location = new System.Drawing.Point(448, 8);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(59, 15);
            this.AddLabel.TabIndex = 40;
            this.AddLabel.Text = "Название";
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.Bottom.Controls.Add(this.AddLabel);
            this.Bottom.Controls.Add(this.gramNameTextbox);
            this.Bottom.Controls.Add(this.errorLabel);
            this.Bottom.Controls.Add(this.AddGramBtn);
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(0, 285);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(734, 31);
            this.Bottom.TabIndex = 42;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.errorLabel.Location = new System.Drawing.Point(6, 8);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(133, 15);
            this.errorLabel.TabIndex = 41;
            this.errorLabel.Text = "Это строка не валидна.";
            // 
            // Rules_Panel
            // 
            this.Rules_Panel.Controls.Add(this.splitContainer3);
            this.Rules_Panel.Controls.Add(this.label1);
            this.Rules_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rules_Panel.Location = new System.Drawing.Point(369, 3);
            this.Rules_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Rules_Panel.MaximumSize = new System.Drawing.Size(0, 45);
            this.Rules_Panel.Name = "Rules_Panel";
            this.Rules_Panel.Size = new System.Drawing.Size(362, 41);
            this.Rules_Panel.TabIndex = 49;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 15);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.Add_Rules_textbox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Add_Rules_Btn);
            this.splitContainer3.Size = new System.Drawing.Size(362, 26);
            this.splitContainer3.SplitterDistance = 213;
            this.splitContainer3.TabIndex = 30;
            // 
            // Add_Rules_textbox
            // 
            this.Add_Rules_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_Rules_textbox.Location = new System.Drawing.Point(0, 0);
            this.Add_Rules_textbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_Rules_textbox.Name = "Add_Rules_textbox";
            this.Add_Rules_textbox.PlaceholderText = "Г-1 Х | 0 Х 1 | h";
            this.Add_Rules_textbox.Size = new System.Drawing.Size(213, 23);
            this.Add_Rules_textbox.TabIndex = 27;
            this.Add_Rules_textbox.TextChanged += new System.EventHandler(this.Add_Rules_textbox_TextChanged);
            // 
            // Add_Rules_Btn
            // 
            this.Add_Rules_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_Rules_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Rules_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_Rules_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_Rules_Btn.Location = new System.Drawing.Point(0, 0);
            this.Add_Rules_Btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_Rules_Btn.Name = "Add_Rules_Btn";
            this.Add_Rules_Btn.Size = new System.Drawing.Size(145, 23);
            this.Add_Rules_Btn.TabIndex = 28;
            this.Add_Rules_Btn.Text = "Добавить";
            this.Add_Rules_Btn.UseVisualStyleBackColor = true;
            this.Add_Rules_Btn.Click += new System.EventHandler(this.Add_Rules_Btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Rules";
            // 
            // VT_Panel
            // 
            this.VT_Panel.Controls.Add(this.splitContainer2);
            this.VT_Panel.Controls.Add(this.VT_Label);
            this.VT_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VT_Panel.Location = new System.Drawing.Point(3, 3);
            this.VT_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.VT_Panel.MaximumSize = new System.Drawing.Size(0, 45);
            this.VT_Panel.Name = "VT_Panel";
            this.VT_Panel.Size = new System.Drawing.Size(177, 41);
            this.VT_Panel.TabIndex = 48;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 15);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Add_VT_textbox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Add_VT_Btn);
            this.splitContainer2.Size = new System.Drawing.Size(177, 26);
            this.splitContainer2.SplitterDistance = 103;
            this.splitContainer2.TabIndex = 30;
            // 
            // Add_VT_textbox
            // 
            this.Add_VT_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_VT_textbox.Location = new System.Drawing.Point(0, 0);
            this.Add_VT_textbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_VT_textbox.Name = "Add_VT_textbox";
            this.Add_VT_textbox.PlaceholderText = "1 , 0 , h";
            this.Add_VT_textbox.Size = new System.Drawing.Size(103, 23);
            this.Add_VT_textbox.TabIndex = 27;
            this.Add_VT_textbox.TextChanged += new System.EventHandler(this.Add_VT_textbox_TextChanged);
            // 
            // Add_VT_Btn
            // 
            this.Add_VT_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_VT_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_VT_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_VT_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_VT_Btn.Location = new System.Drawing.Point(0, 0);
            this.Add_VT_Btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_VT_Btn.Name = "Add_VT_Btn";
            this.Add_VT_Btn.Size = new System.Drawing.Size(70, 23);
            this.Add_VT_Btn.TabIndex = 28;
            this.Add_VT_Btn.Text = "Добавить";
            this.Add_VT_Btn.UseVisualStyleBackColor = true;
            this.Add_VT_Btn.Click += new System.EventHandler(this.Add_VT_Btn_Click);
            // 
            // VT_Label
            // 
            this.VT_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.VT_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VT_Label.Location = new System.Drawing.Point(0, 0);
            this.VT_Label.Name = "VT_Label";
            this.VT_Label.Size = new System.Drawing.Size(177, 15);
            this.VT_Label.TabIndex = 29;
            this.VT_Label.Text = "VT";
            // 
            // VN_Panel
            // 
            this.VN_Panel.Controls.Add(this.splitContainer1);
            this.VN_Panel.Controls.Add(this.label2);
            this.VN_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VN_Panel.Location = new System.Drawing.Point(186, 3);
            this.VN_Panel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.VN_Panel.MaximumSize = new System.Drawing.Size(0, 45);
            this.VN_Panel.Name = "VN_Panel";
            this.VN_Panel.Size = new System.Drawing.Size(177, 41);
            this.VN_Panel.TabIndex = 44;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 15);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Add_VN_textbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Add_VN_Button);
            this.splitContainer1.Size = new System.Drawing.Size(177, 26);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 30;
            // 
            // Add_VN_List
            // 
            this.Add_VN_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_VN_List.FormattingEnabled = true;
            this.Add_VN_List.ItemHeight = 15;
            this.Add_VN_List.Location = new System.Drawing.Point(186, 47);
            this.Add_VN_List.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_VN_List.Name = "Add_VN_List";
            this.Add_VN_List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Add_VN_List.Size = new System.Drawing.Size(177, 238);
            this.Add_VN_List.TabIndex = 26;
            this.Add_VN_List.Leave += new System.EventHandler(this.Add_VN_List_Leave);
            this.Add_VN_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_VN_List_MouseDown);
            // 
            // Add_Rules_List
            // 
            this.Add_Rules_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_Rules_List.FormattingEnabled = true;
            this.Add_Rules_List.ItemHeight = 15;
            this.Add_Rules_List.Location = new System.Drawing.Point(369, 47);
            this.Add_Rules_List.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Add_Rules_List.Name = "Add_Rules_List";
            this.Add_Rules_List.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Add_Rules_List.Size = new System.Drawing.Size(362, 238);
            this.Add_Rules_List.TabIndex = 33;
            this.Add_Rules_List.Leave += new System.EventHandler(this.Add_Rules_List_Leave);
            this.Add_Rules_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Add_Rules_List_MouseDown);
            // 
            // ContentTable
            // 
            this.ContentTable.AutoSize = true;
            this.ContentTable.ColumnCount = 3;
            this.ContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ContentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContentTable.Controls.Add(this.Rules_Panel, 2, 0);
            this.ContentTable.Controls.Add(this.VT_Panel, 0, 0);
            this.ContentTable.Controls.Add(this.VN_Panel, 1, 0);
            this.ContentTable.Controls.Add(this.Add_VT_List, 0, 1);
            this.ContentTable.Controls.Add(this.Add_Rules_List, 2, 1);
            this.ContentTable.Controls.Add(this.Add_VN_List, 1, 1);
            this.ContentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTable.Location = new System.Drawing.Point(0, 0);
            this.ContentTable.Margin = new System.Windows.Forms.Padding(12, 3, 6, 3);
            this.ContentTable.Name = "ContentTable";
            this.ContentTable.RowCount = 2;
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ContentTable.Size = new System.Drawing.Size(734, 285);
            this.ContentTable.TabIndex = 43;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(734, 316);
            this.Controls.Add(this.ContentTable);
            this.Controls.Add(this.Bottom);
            this.Name = "AddForm";
            this.Text = "Новая грамматика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.Bottom.ResumeLayout(false);
            this.Bottom.PerformLayout();
            this.Rules_Panel.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.VT_Panel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.VN_Panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ContentTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button Add_VN_Button;
        private TextBox Add_VN_textbox;
        private ListBox Add_VT_List;
        private ToolTip toolTip1;
        private TextBox gramNameTextbox;
        private Button AddGramBtn;
        private Label AddLabel;
        private Panel Bottom;
        private Panel VN_Panel;
        private SplitContainer splitContainer1;
        private Panel Rules_Panel;
        private SplitContainer splitContainer3;
        private TextBox Add_Rules_textbox;
        private Button Add_Rules_Btn;
        private Label label1;
        private Panel VT_Panel;
        private SplitContainer splitContainer2;
        private TextBox Add_VT_textbox;
        private Button Add_VT_Btn;
        private Label VT_Label;
        private ListBox Add_VN_List;
        private ListBox Add_Rules_List;
        private TableLayoutPanel ContentTable;
        private Label errorLabel;
    }
}