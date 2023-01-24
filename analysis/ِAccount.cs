namespace Final
{
    public partial class _ِAccount : UserControl
    {
        Excel sh = new Excel(@"../../../Database/Book2.xlsx", "Users");
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
            if (userName == "admin")
                RuleTextBox.Text = "admin";

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
            if (sh.getPass(userName, CurrentPasswordTextBox.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            newPasstxb.Visible = true;
            ConfirmTextBox.Visible = true;
            CurrentPasswordTextBox.Visible = true;
            checkBox_showpass.Visible = true;
            SaveChagesBtn.Visible = true;
            ChangeButton.Visible = false;
        }
    }
}
