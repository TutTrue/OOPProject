namespace Final
{
    public partial class LoginForm : Form
    {


        Excel sh = new Excel(@"../../../Database/Book2.xlsx", "Users");
        public LoginForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                PasswordLog.UseSystemPasswordChar = true;
                var checkBox_showpass = (CheckBox)sender;
            }
            else
            {
                PasswordLog.UseSystemPasswordChar = false;
                var checkBox_showpass = (CheckBox)sender;
            }
        }

        private void CreateAc_Click(object sender, EventArgs e)
        {
            Hide();
            Regester_Form r = new Regester_Form();
            r.ShowDialog();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (sh.getPass(UsernameLog.Text, PasswordLog.Text))
            {
                Main frm = new Main();

                frm.userName = UsernameLog.Text;
                frm.Show();

                Hide();

            }
            else
            {
                MessageBox.Show("USER NAME OR PASSWORD IS NOT CORRECT");
                PasswordLog.Text = "";
                UsernameLog.Text = "";
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UsernameLog.Text = string.Empty;
            PasswordLog.Text = string.Empty;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
