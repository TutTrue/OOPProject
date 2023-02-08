namespace Final
{
    public partial class Dashboard : Form
    {
        Excel sh = new Excel("seats");
        Button[] buttons;
        string userName;
        public Dashboard(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        //go to Main and save seats taken in data base
        private void Done_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successed Booking!!");
            Main frm = new Main(userName);
            foreach (int b in booking)
            {

                if (b == 0)
                {
                    continue;
                }
                sh.saveSeats(b, userName);

            }  //save seats taken in data base
            frm.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main frm = new Main(userName);
            frm.Show();
            Hide();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12,
                btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20, btn21, btn22, btn23, btn24, btn25,
                btn26, btn27, btn28, btn29, btn30, btn31, btn32, btn33, btn34, btn35, btn36, btn37, btn38,
                btn39, btn40, btn41, btn42, btn43, btn44, btn45, btn46, btn47, btn48, btn49, btn50, btn51,
                btn52, btn53 }; //array of seats
            foreach (string s in sh.getAllSeats())
            {
                // if s =1 then it refears to seat 1 which is the first index of an array buttons[0]
                buttons[int.Parse(s)-1].Enabled = false;
                buttons[int.Parse(s) - 1].BackColor = Color.FromArgb(203, 237, 213);
                
            }  //make taken seats disable
            foreach (string s in sh.getMySeats(userName))
            {
                // if s =1 then it refears to seat 1 which is the first index of an array buttons[0]
                buttons[int.Parse(s) - 1].Enabled = false;
                buttons[int.Parse(s) - 1].BackColor = Color.FromArgb(67, 154, 151);
                
            } //make current user seats green


        }
        public int[] booking = new int[53];
        int i = 1;
        //change color of buttons
        private void btns_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.FromArgb(67, 154, 151);
                b.ForeColor = Color.White;
                booking[i] = int.Parse(b.Text);
                i++;
            }
            else
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(67, 154, 151);
                for (int j = 1; j < booking.Length; j++)
                {
                    if (booking[j] == int.Parse(b.Text))
                    {
                        booking[j] = 0;
                        i--;
                        break;
                    }
                }
            }
        }
        //close form
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minmize Form
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}

