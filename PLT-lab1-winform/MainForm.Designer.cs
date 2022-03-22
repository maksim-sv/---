namespace PLT_lab1_winform
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.GitPanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Tab_Build = new System.Windows.Forms.Button();
            this.Tab_Add = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GitPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(14, 55);
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(783, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "исходный код: https://github.com/maksim-sv/PLT-lab1";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Orchid;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // GitPanel
            // 
            this.GitPanel.Controls.Add(this.linkLabel1);
            this.GitPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GitPanel.Location = new System.Drawing.Point(0, 291);
            this.GitPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GitPanel.Name = "GitPanel";
            this.GitPanel.Size = new System.Drawing.Size(783, 25);
            this.GitPanel.TabIndex = 22;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.Tab_Build);
            this.panelMenu.Controls.Add(this.Tab_Add);
            this.panelMenu.Controls.Add(this.LoginPanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(161, 346);
            this.panelMenu.TabIndex = 23;
            // 
            // Tab_Build
            // 
            this.Tab_Build.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Tab_Build.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Build.FlatAppearance.BorderSize = 0;
            this.Tab_Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab_Build.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tab_Build.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tab_Build.Image = global::PLT_lab1_winform.Properties.Resources.tree_40x40;
            this.Tab_Build.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Build.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Tab_Build.Location = new System.Drawing.Point(0, 90);
            this.Tab_Build.Name = "Tab_Build";
            this.Tab_Build.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Tab_Build.Size = new System.Drawing.Size(161, 60);
            this.Tab_Build.TabIndex = 1;
            this.Tab_Build.Text = " Построить";
            this.Tab_Build.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Build.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tab_Build.UseVisualStyleBackColor = false;
            this.Tab_Build.Click += new System.EventHandler(this.Tab_Build_Click);
            // 
            // Tab_Add
            // 
            this.Tab_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Tab_Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab_Add.FlatAppearance.BorderSize = 0;
            this.Tab_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab_Add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tab_Add.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tab_Add.Image = ((System.Drawing.Image)(resources.GetObject("Tab_Add.Image")));
            this.Tab_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tab_Add.Location = new System.Drawing.Point(0, 30);
            this.Tab_Add.Name = "Tab_Add";
            this.Tab_Add.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Tab_Add.Size = new System.Drawing.Size(161, 60);
            this.Tab_Add.TabIndex = 0;
            this.Tab_Add.Text = " Новая грамматика";
            this.Tab_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tab_Add.UseVisualStyleBackColor = false;
            this.Tab_Add.Click += new System.EventHandler(this.Tab_Add_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.LoginPanel.Controls.Add(this.panelLogo);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(161, 30);
            this.LoginPanel.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(161, 30);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Text = "Свитецкий М. А.  157ом";
            this.panelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(60, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(723, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "О программе";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::PLT_lab1_winform.Properties.Resources.close_40x40;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(60, 30);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(161, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(783, 30);
            this.panelTitleBar.TabIndex = 24;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Controls.Add(this.GitPanel);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(161, 30);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(783, 316);
            this.panelDesktopPane.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 291);
            this.label1.TabIndex = 23;
            this.label1.Text = "Программа для построения цепочек \r\nпо заданной грамматике";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(944, 346);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 385);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GramTree";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GitPanel.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LinkLabel linkLabel1;
        private Panel panelMenu;
        private Button Tab_Add;
        private Panel GitPanel;
        private Button Tab_Build;
        private Panel panelTitleBar;
        private Label panelLogo;
        private Panel LoginPanel;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
        private Label label1;
        private Label lblTitle;
    }
}