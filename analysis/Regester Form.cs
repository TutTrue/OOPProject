﻿namespace Final
{
    public partial class Regester_Form : Form
    {

        Excel sh = new Excel("Users");

        public Regester_Form()
        {
            InitializeComponent();
        }

        private void checkBox_rshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rshowpass.Checked)
            {
                PasswordRig.UseSystemPasswordChar = true;
                ConfirmRig.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordRig.UseSystemPasswordChar = false;
                ConfirmRig.UseSystemPasswordChar = false;
            }
        }

        private void BackTologin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm l = new LoginForm();

            l.ShowDialog();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UsernameRig.Text = string.Empty;
            PasswordRig.Text = string.Empty;
            ConfirmRig.Text = string.Empty;
        }

        private void Rigester_Click(object sender, EventArgs e)
        {

            if (PasswordRig.Text == ConfirmRig.Text)
            {
                User newUser = new User(UsernameRig.Text, PasswordRig.Text);
                sh.addNewUser(newUser);
                LoginForm frm = new LoginForm();

                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("ENTER SAME PASSWORD");
                PasswordRig.Text = string.Empty;
                ConfirmRig.Text = string.Empty;
            }


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
