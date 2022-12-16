using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class _ِAccount : UserControl
    {
        Excel sh = new Excel(@"Book2.xlsx", "Users");
        public string? userName;

        public _ِAccount()
        {
            InitializeComponent();
        }

        public _ِAccount(string username)
        {
            userName = username;
            InitializeComponent();
            UserTextBox.Text = userName;
            

        }


        private void _ِAccount_Load(object sender, EventArgs e)
        {
           
            CurrentPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                CurrentPasswordTextBox.UseSystemPasswordChar = false;
                var checkBox_showpass = (CheckBox)sender;
            }
            else
            {
                CurrentPasswordTextBox.UseSystemPasswordChar = true;
                var checkBox_showpass = (CheckBox)sender;
            }
        }

        private void SaveChagesBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPasswordTextBox.Text == sh.getPass(userName))
            {
                if (newPasstxb.Text == ConfirmTextBox.Text)
                {
                    sh.changePass(userName, newPasstxb.Text);
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("new password and confirm new password must be the same");
                }
            }
            else
            {
                MessageBox.Show("Wrong password");
            }
            
            
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm frm= new LoginForm();
            frm.Show();

        }
    }
}
