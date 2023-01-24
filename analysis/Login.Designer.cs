namespace Final
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameLog = new System.Windows.Forms.TextBox();
            this.PasswordLog = new System.Windows.Forms.TextBox();
            this.checkBox_showpass = new System.Windows.Forms.CheckBox();
            this.Login = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateAc = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 24.21818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(41, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(38, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // UsernameLog
            // 
            this.UsernameLog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UsernameLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.UsernameLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameLog.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.UsernameLog.Location = new System.Drawing.Point(41, 211);
            this.UsernameLog.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.UsernameLog.Multiline = true;
            this.UsernameLog.Name = "UsernameLog";
            this.UsernameLog.Size = new System.Drawing.Size(318, 32);
            this.UsernameLog.TabIndex = 0;
            this.UsernameLog.WordWrap = false;
            // 
            // PasswordLog
            // 
            this.PasswordLog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PasswordLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.PasswordLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordLog.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswordLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.PasswordLog.Location = new System.Drawing.Point(41, 307);
            this.PasswordLog.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PasswordLog.Multiline = true;
            this.PasswordLog.Name = "PasswordLog";
            this.PasswordLog.PasswordChar = '*';
            this.PasswordLog.Size = new System.Drawing.Size(318, 32);
            this.PasswordLog.TabIndex = 1;
            this.PasswordLog.WordWrap = false;
            // 
            // checkBox_showpass
            // 
            this.checkBox_showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showpass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_showpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.checkBox_showpass.Location = new System.Drawing.Point(41, 362);
            this.checkBox_showpass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBox_showpass.Name = "checkBox_showpass";
            this.checkBox_showpass.Size = new System.Drawing.Size(157, 27);
            this.checkBox_showpass.TabIndex = 2;
            this.checkBox_showpass.Text = "Show Password";
            this.checkBox_showpass.UseVisualStyleBackColor = true;
            this.checkBox_showpass.CheckedChanged += new System.EventHandler(this.checkBox_showpass_CheckedChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(41, 418);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(318, 47);
            this.Login.TabIndex = 3;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.Clear.Location = new System.Drawing.Point(41, 483);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(318, 47);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(41, 557);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t Have an Account ?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateAc
            // 
            this.CreateAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAc.FlatAppearance.BorderSize = 0;
            this.CreateAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAc.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.CreateAc.Location = new System.Drawing.Point(108, 597);
            this.CreateAc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CreateAc.Name = "CreateAc";
            this.CreateAc.Size = new System.Drawing.Size(169, 37);
            this.CreateAc.TabIndex = 5;
            this.CreateAc.Text = "Create Account";
            this.CreateAc.UseVisualStyleBackColor = true;
            this.CreateAc.Click += new System.EventHandler(this.CreateAc_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Navy;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(324, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(34, 30);
            this.MinimizeBtn.TabIndex = 10;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Navy;
            this.CloseBtn.Image = global::analysis.Properties.Resources.icons8_macos_close_30;
            this.CloseBtn.Location = new System.Drawing.Point(358, 0);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 30);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 704);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CreateAc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.checkBox_showpass);
            this.Controls.Add(this.PasswordLog);
            this.Controls.Add(this.UsernameLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameLog;
        private System.Windows.Forms.TextBox PasswordLog;
        private System.Windows.Forms.CheckBox checkBox_showpass;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateAc;
        private Button MinimizeBtn;
        private Button CloseBtn;
    }
}

