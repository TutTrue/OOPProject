namespace Final
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuPanal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.AnalyticsBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.DataPanal = new System.Windows.Forms.Panel();
            this.Rule = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlPanal = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ShowPanal = new System.Windows.Forms.Panel();
            this.Book = new System.Windows.Forms.Button();
            this.MenuPanal.SuspendLayout();
            this.DataPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanal
            // 
            this.MenuPanal.BackColor = System.Drawing.Color.White;
            this.MenuPanal.Controls.Add(this.button1);
            this.MenuPanal.Controls.Add(this.PnlNav);
            this.MenuPanal.Controls.Add(this.SettingBtn);
            this.MenuPanal.Controls.Add(this.username);
            this.MenuPanal.Controls.Add(this.AccountBtn);
            this.MenuPanal.Controls.Add(this.AnalyticsBtn);
            this.MenuPanal.Controls.Add(this.DashboardBtn);
            this.MenuPanal.Controls.Add(this.DataPanal);
            this.MenuPanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanal.Location = new System.Drawing.Point(0, 0);
            this.MenuPanal.Name = "MenuPanal";
            this.MenuPanal.Size = new System.Drawing.Size(186, 707);
            this.MenuPanal.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 184);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 95);
            this.PnlNav.TabIndex = 3;
            // 
            // SettingBtn
            // 
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SettingBtn.Image = global::analysis.Properties.Resources.icons8_settings_30;
            this.SettingBtn.Location = new System.Drawing.Point(0, 237);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(186, 53);
            this.SettingBtn.TabIndex = 2;
            this.SettingBtn.Text = "Trip Setting";
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            this.SettingBtn.Leave += new System.EventHandler(this.SettingBtn_Leave);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(121)))));
            this.username.Location = new System.Drawing.Point(41, 80);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(101, 22);
            this.username.TabIndex = 1;
            this.username.Text = "User Name";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountBtn
            // 
            this.AccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccountBtn.FlatAppearance.BorderSize = 0;
            this.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AccountBtn.Image = global::analysis.Properties.Resources.icons8_user_35;
            this.AccountBtn.Location = new System.Drawing.Point(0, 654);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(186, 53);
            this.AccountBtn.TabIndex = 2;
            this.AccountBtn.Text = "Account";
            this.AccountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            this.AccountBtn.Leave += new System.EventHandler(this.AccountBtn_Leave);
            // 
            // AnalyticsBtn
            // 
            this.AnalyticsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalyticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnalyticsBtn.FlatAppearance.BorderSize = 0;
            this.AnalyticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalyticsBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnalyticsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.AnalyticsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AnalyticsBtn.Image")));
            this.AnalyticsBtn.Location = new System.Drawing.Point(0, 184);
            this.AnalyticsBtn.Name = "AnalyticsBtn";
            this.AnalyticsBtn.Size = new System.Drawing.Size(186, 53);
            this.AnalyticsBtn.TabIndex = 2;
            this.AnalyticsBtn.Text = "Analytics";
            this.AnalyticsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnalyticsBtn.UseVisualStyleBackColor = true;
            this.AnalyticsBtn.Click += new System.EventHandler(this.AnalyticsBtn_Click);
            this.AnalyticsBtn.Leave += new System.EventHandler(this.AnalyticsBtn_Leave);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.Image")));
            this.DashboardBtn.Location = new System.Drawing.Point(0, 131);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(186, 53);
            this.DashboardBtn.TabIndex = 2;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            this.DashboardBtn.Leave += new System.EventHandler(this.DashboardBtn_Leave);
            // 
            // DataPanal
            // 
            this.DataPanal.Controls.Add(this.Rule);
            this.DataPanal.Controls.Add(this.pictureBox1);
            this.DataPanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPanal.Location = new System.Drawing.Point(0, 0);
            this.DataPanal.Name = "DataPanal";
            this.DataPanal.Size = new System.Drawing.Size(186, 131);
            this.DataPanal.TabIndex = 1;
            // 
            // Rule
            // 
            this.Rule.AutoSize = true;
            this.Rule.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.Rule.Location = new System.Drawing.Point(72, 112);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(33, 13);
            this.Rule.TabIndex = 1;
            this.Rule.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ControlPanal
            // 
            this.ControlPanal.BackColor = System.Drawing.Color.White;
            this.ControlPanal.Controls.Add(this.MinimizeBtn);
            this.ControlPanal.Controls.Add(this.CloseBtn);
            this.ControlPanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanal.Location = new System.Drawing.Point(186, 0);
            this.ControlPanal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ControlPanal.Name = "ControlPanal";
            this.ControlPanal.Size = new System.Drawing.Size(1057, 43);
            this.ControlPanal.TabIndex = 1;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(989, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(34, 33);
            this.MinimizeBtn.TabIndex = 0;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Image = global::analysis.Properties.Resources.icons8_macos_close_30;
            this.CloseBtn.Location = new System.Drawing.Point(1023, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 33);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ShowPanal
            // 
            this.ShowPanal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPanal.BackColor = System.Drawing.Color.White;
            this.ShowPanal.Location = new System.Drawing.Point(186, 41);
            this.ShowPanal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPanal.Name = "ShowPanal";
            this.ShowPanal.Size = new System.Drawing.Size(1057, 594);
            this.ShowPanal.TabIndex = 2;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.SystemColors.Control;
            this.Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Book.FlatAppearance.BorderSize = 0;
            this.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Book.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(121)))));
            this.Book.Location = new System.Drawing.Point(611, 651);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(169, 44);
            this.Book.TabIndex = 7;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 707);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.ShowPanal);
            this.Controls.Add(this.ControlPanal);
            this.Controls.Add(this.MenuPanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasicPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuPanal.ResumeLayout(false);
            this.DataPanal.ResumeLayout(false);
            this.DataPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlPanal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanal;
        private Button DashboardBtn;
        private Panel DataPanal;
        private Label Rule;
        private PictureBox pictureBox1;
        private Button SettingBtn;
        private Button AccountBtn;
        private Button AnalyticsBtn;
        private Panel PnlNav;
        private Panel ControlPanal;
        private Button MinimizeBtn;
        private Button CloseBtn;
        private Panel ShowPanal;
        private Button button1;
        public Label username;
        private Button Book;
    }
}