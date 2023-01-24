namespace Final
{
    partial class _ِAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ِAccount));
            this.AccountPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveChagesBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.checkBox_showpass = new System.Windows.Forms.CheckBox();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.RuleTextBox = new System.Windows.Forms.TextBox();
            this.newPasstxb = new System.Windows.Forms.TextBox();
            this.CurrentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPictureBox)).BeginInit();
            this.AccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountPictureBox
            // 
            this.AccountPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AccountPictureBox.Image")));
            this.AccountPictureBox.Location = new System.Drawing.Point(353, 0);
            this.AccountPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountPictureBox.Name = "AccountPictureBox";
            this.AccountPictureBox.Size = new System.Drawing.Size(281, 141);
            this.AccountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AccountPictureBox.TabIndex = 1;
            this.AccountPictureBox.TabStop = false;
            // 
            // SaveChagesBtn
            // 
            this.SaveChagesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.SaveChagesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChagesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.SaveChagesBtn.FlatAppearance.BorderSize = 0;
            this.SaveChagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.SaveChagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChagesBtn.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveChagesBtn.ForeColor = System.Drawing.Color.White;
            this.SaveChagesBtn.Location = new System.Drawing.Point(669, 253);
            this.SaveChagesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveChagesBtn.Name = "SaveChagesBtn";
            this.SaveChagesBtn.Size = new System.Drawing.Size(120, 43);
            this.SaveChagesBtn.TabIndex = 4;
            this.SaveChagesBtn.Text = "Save";
            this.SaveChagesBtn.UseVisualStyleBackColor = false;
            this.SaveChagesBtn.Visible = false;
            this.SaveChagesBtn.Click += new System.EventHandler(this.SaveChagesBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(85, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(85, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "New password :";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label5.Location = new System.Drawing.Point(85, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirm password :";
            this.label5.Visible = false;
            // 
            // AccountGroupBox
            // 
            this.AccountGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountGroupBox.Controls.Add(this.ChangeButton);
            this.AccountGroupBox.Controls.Add(this.checkBox_showpass);
            this.AccountGroupBox.Controls.Add(this.ConfirmTextBox);
            this.AccountGroupBox.Controls.Add(this.RuleTextBox);
            this.AccountGroupBox.Controls.Add(this.newPasstxb);
            this.AccountGroupBox.Controls.Add(this.CurrentPasswordTextBox);
            this.AccountGroupBox.Controls.Add(this.UserTextBox);
            this.AccountGroupBox.Controls.Add(this.label2);
            this.AccountGroupBox.Controls.Add(this.SaveChagesBtn);
            this.AccountGroupBox.Controls.Add(this.label6);
            this.AccountGroupBox.Controls.Add(this.label3);
            this.AccountGroupBox.Controls.Add(this.label4);
            this.AccountGroupBox.Controls.Add(this.label5);
            this.AccountGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.AccountGroupBox.Location = new System.Drawing.Point(57, 127);
            this.AccountGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountGroupBox.Name = "AccountGroupBox";
            this.AccountGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AccountGroupBox.Size = new System.Drawing.Size(920, 428);
            this.AccountGroupBox.TabIndex = 7;
            this.AccountGroupBox.TabStop = false;
            this.AccountGroupBox.Text = "Account Information";
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeButton.Location = new System.Drawing.Point(360, 157);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(215, 52);
            this.ChangeButton.TabIndex = 10;
            this.ChangeButton.Text = "Change Password";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_showpass
            // 
            this.checkBox_showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showpass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.checkBox_showpass.Location = new System.Drawing.Point(458, 382);
            this.checkBox_showpass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBox_showpass.Name = "checkBox_showpass";
            this.checkBox_showpass.Size = new System.Drawing.Size(168, 27);
            this.checkBox_showpass.TabIndex = 3;
            this.checkBox_showpass.Text = "Show Password";
            this.checkBox_showpass.UseVisualStyleBackColor = false;
            this.checkBox_showpass.Visible = false;
            this.checkBox_showpass.CheckedChanged += new System.EventHandler(this.checkBox_showpass_CheckedChanged);
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.ConfirmTextBox.Location = new System.Drawing.Point(278, 246);
            this.ConfirmTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(324, 35);
            this.ConfirmTextBox.TabIndex = 1;
            this.ConfirmTextBox.Visible = false;
            // 
            // RuleTextBox
            // 
            this.RuleTextBox.Enabled = false;
            this.RuleTextBox.Font = new System.Drawing.Font("Segoe Print", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RuleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.RuleTextBox.Location = new System.Drawing.Point(731, 85);
            this.RuleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RuleTextBox.Name = "RuleTextBox";
            this.RuleTextBox.ReadOnly = true;
            this.RuleTextBox.Size = new System.Drawing.Size(170, 38);
            this.RuleTextBox.TabIndex = 7;
            this.RuleTextBox.Text = "User";
            this.RuleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPasstxb
            // 
            this.newPasstxb.BackColor = System.Drawing.SystemColors.Control;
            this.newPasstxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasstxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasstxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.newPasstxb.Location = new System.Drawing.Point(278, 157);
            this.newPasstxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasstxb.Name = "newPasstxb";
            this.newPasstxb.Size = new System.Drawing.Size(324, 35);
            this.newPasstxb.TabIndex = 0;
            this.newPasstxb.Visible = false;
            // 
            // CurrentPasswordTextBox
            // 
            this.CurrentPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CurrentPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.CurrentPasswordTextBox.Location = new System.Drawing.Point(278, 324);
            this.CurrentPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox";
            this.CurrentPasswordTextBox.Size = new System.Drawing.Size(324, 35);
            this.CurrentPasswordTextBox.TabIndex = 2;
            this.CurrentPasswordTextBox.Visible = false;
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.UserTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.UserTextBox.Enabled = false;
            this.UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.UserTextBox.Location = new System.Drawing.Point(278, 90);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.ReadOnly = true;
            this.UserTextBox.Size = new System.Drawing.Size(324, 35);
            this.UserTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(85, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label6.Location = new System.Drawing.Point(669, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rule:";
            // 
            // _ِAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.AccountGroupBox);
            this.Controls.Add(this.AccountPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_ِAccount";
            this.Size = new System.Drawing.Size(1034, 666);
            this.Load += new System.EventHandler(this._ِAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountPictureBox)).EndInit();
            this.AccountGroupBox.ResumeLayout(false);
            this.AccountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox AccountPictureBox;
        private Button SaveChagesBtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox AccountGroupBox;
        private Label label2;
        private Label label6;
        private TextBox ConfirmTextBox;
        private TextBox RuleTextBox;
        private TextBox newPasstxb;
        private TextBox CurrentPasswordTextBox;
        private TextBox UserTextBox;
        private CheckBox checkBox_showpass;
        private Button ChangeButton;
    }
}
