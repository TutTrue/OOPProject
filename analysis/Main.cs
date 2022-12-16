using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 
namespace Final
{
    public partial class Main : Form
    {
        ///*To make the form dragable*/
        //[DllImport("User32.dll")]
        //public static extern bool ReleaseCapture();
        //[DllImport("User32.dll")]
        //public static extern int SendMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);
        //private void OnMouseDown(object sender, MouseEventArgs e)
        //{
        //    if(e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        //SendMessage(Handle, 0xA1, 0x2, 0);
        //    }
        //}
        ///*To make the form dragable*/
        public string? userName;
        Excel sh = new Excel(@"Book2.xlsx", "seats");
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
            ShowPanal.Controls.Add(frm);
            frm.BringToFront();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = DashboardBtn.Height;
            PnlNav.Top= DashboardBtn.Top; 
            PnlNav.Left= DashboardBtn.Left;
            DashboardBtn.BackColor = Color.FromArgb(235, 235, 235);
            Book.Visible = true;
            Welcome_page frm = new Welcome_page();
            ShowPanal.Controls.Add(frm);
            frm.BringToFront();
        }

        private void AnalyticsBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = AnalyticsBtn.Height;
            PnlNav.Top = AnalyticsBtn.Top;
            PnlNav.Left = AnalyticsBtn.Left;
            AnalyticsBtn.BackColor = Color.FromArgb(235, 235, 235);
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = SettingBtn.Height;
            PnlNav.Top = SettingBtn.Top;
            PnlNav.Left = SettingBtn.Left;
            SettingBtn.BackColor = Color.FromArgb(235, 235, 235);
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            //_ِAccount a = new _ِAccount(userName);


            PnlNav.Height = AccountBtn.Height;
            PnlNav.Top = AccountBtn.Top;
            PnlNav.Left = AccountBtn.Left;
            AccountBtn.BackColor = Color.FromArgb(235, 235, 235);
            _ِAccount a1 = new _ِAccount(userName);
            ShowPanal.Controls.Add(a1);
            a1.BringToFront();
            Book.Visible = false;
        }

        private void DashboardBtn_Leave(object sender, EventArgs e)
        {
            DashboardBtn.BackColor = Color.White;
        }

        private void AnalyticsBtn_Leave(object sender, EventArgs e)
        {
            AnalyticsBtn.BackColor = Color.White;
        }

        private void SettingBtn_Leave(object sender, EventArgs e)
        {
            SettingBtn.BackColor = Color.White;
        }

        private void AccountBtn_Leave(object sender, EventArgs e)
        {
            AccountBtn.BackColor = Color.White;
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
            LoginForm frm=new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(userName);
            
            frm.Show();
            Hide();
        }
    }
}