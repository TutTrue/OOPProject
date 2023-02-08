namespace Final
{
    public partial class Main : Form
    {
        public string? userName;
        public string tripName;
        Excel sh = new Excel("seats");
        Excel tripWorkbook = new Excel("tripSetting");

        public Main()
        {
            InitializeComponent();
            PnlNav.Height = DashboardBtn.Height;
            PnlNav.Top = DashboardBtn.Top;
            PnlNav.Left = DashboardBtn.Left;
            DashboardBtn.BackColor = Color.FromArgb(235, 235, 235);
        }
        public Main(string userName)
        {
            this.userName = userName;
            InitializeComponent();
            PnlNav.Height = DashboardBtn.Height;
            PnlNav.Top = DashboardBtn.Top;
            PnlNav.Left = DashboardBtn.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            username.Text = userName;
            Welcome_page frm = new Welcome_page();
            //appears buttons
            //account admin
            if (userName == "admin")
            {
                SettingBtn.Visible = true;
                Rule.Text = "admin";
            }
            ShowPanal.Controls.Add(frm);
            frm.BringToFront();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = DashboardBtn.Height;
            PnlNav.Top = DashboardBtn.Top;
            PnlNav.Left = DashboardBtn.Left;
            DashboardBtn.BackColor = Color.FromArgb(235, 235, 235);
            //appear when click dashboard btn only
            Book.Visible = true;
            removeBooking.Visible = true;

            Welcome_page frm = new Welcome_page();
            ShowPanal.Controls.Add(frm);
            frm.BringToFront();
        }
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SettingBtn.Height;
            PnlNav.Top = SettingBtn.Top;
            PnlNav.Left = SettingBtn.Left;
            SettingBtn.BackColor = Color.FromArgb(235, 235, 235);
            Book.Visible = false;
            TripSettings frm = new TripSettings(userName);
            frm.Show();
            Hide();
        }
        _ِAccount a1;
        private void AccountBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = AccountBtn.Height;
            PnlNav.Top = AccountBtn.Top;
            PnlNav.Left = AccountBtn.Left;
            AccountBtn.BackColor = Color.FromArgb(235, 235, 235);
            a1 = new _ِAccount(userName);
            ShowPanal.Controls.Add(a1);
            a1.BringToFront();
            Book.Visible = false;
            removeBooking.Visible = false;
        }

        private void DashboardBtn_Leave(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.FromArgb(240, 253, 245);
        }


        private void SettingBtn_Leave(object sender, EventArgs e)
        {
            SettingBtn.BackColor = Color.FromArgb(240, 253, 245);
        }

        private void AccountBtn_Leave(object sender, EventArgs e)
        {
            AccountBtn.BackColor = Color.FromArgb(240, 253, 245);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(userName);
            frm.Show();
            Hide();
        }

        //remove my seats only from data base
        private void removeBooking_Click(object sender, EventArgs e)
        {
            sh.removeMySeats(userName);
            MessageBox.Show("Done");
        }


    }
}