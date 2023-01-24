namespace Final
{
    public partial class Dashboard : Form
    {
        Excel sh = new Excel(@"../../../Database/Book2.xlsx", "seats");
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
                switch (s)
                {
                    case "1":
                        buttons[0].Enabled = false;
                        buttons[0].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "2":
                        buttons[1].Enabled = false;
                        buttons[1].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "3":
                        buttons[2].Enabled = false;
                        buttons[2].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "4":
                        buttons[3].Enabled = false;
                        buttons[3].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "5":
                        buttons[4].Enabled = false;
                        buttons[4].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "6":
                        buttons[5].Enabled = false;
                        buttons[5].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "7":
                        buttons[6].Enabled = false;
                        buttons[6].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "8":
                        buttons[7].Enabled = false;
                        buttons[7].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "9":
                        buttons[8].Enabled = false;
                        buttons[8].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "10":
                        buttons[9].Enabled = false;
                        buttons[9].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "11":
                        buttons[10].Enabled = false;
                        buttons[10].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "12":
                        buttons[11].Enabled = false;
                        buttons[11].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "13":
                        buttons[12].Enabled = false;
                        buttons[12].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "14":
                        buttons[13].Enabled = false;
                        buttons[13].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "15":
                        buttons[14].Enabled = false;
                        buttons[14].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "16":
                        buttons[15].Enabled = false;
                        buttons[15].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "17":
                        buttons[16].Enabled = false;
                        buttons[16].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "18":
                        buttons[17].Enabled = false;
                        buttons[17].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "19":
                        buttons[18].Enabled = false;
                        buttons[18].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "20":
                        buttons[19].Enabled = false;
                        buttons[19].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "21":
                        buttons[20].Enabled = false;
                        buttons[20].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "22":
                        buttons[21].Enabled = false;
                        buttons[21].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "23":
                        buttons[22].Enabled = false;
                        buttons[22].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "24":
                        buttons[23].Enabled = false;
                        buttons[23].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "25":
                        buttons[24].Enabled = false;
                        buttons[24].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "26":
                        buttons[25].Enabled = false;
                        buttons[25].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "27":
                        buttons[26].Enabled = false;
                        buttons[26].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "28":
                        buttons[27].Enabled = false;
                        buttons[27].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "29":
                        buttons[28].Enabled = false;
                        buttons[28].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "30":
                        buttons[29].Enabled = false;
                        buttons[29].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "31":
                        buttons[30].Enabled = false;
                        buttons[30].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "32":
                        buttons[31].Enabled = false;
                        buttons[31].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "33":
                        buttons[32].Enabled = false;
                        buttons[32].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "34":
                        buttons[33].Enabled = false;
                        buttons[33].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "35":
                        buttons[34].Enabled = false;
                        buttons[34].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "36":
                        buttons[35].Enabled = false;
                        buttons[35].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "37":
                        buttons[36].Enabled = false;
                        buttons[36].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "38":
                        buttons[37].Enabled = false;
                        buttons[37].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "39":
                        buttons[38].Enabled = false;
                        buttons[38].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "40":
                        buttons[39].Enabled = false;
                        buttons[39].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "41":
                        buttons[40].Enabled = false;
                        buttons[40].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "42":
                        buttons[41].Enabled = false;
                        buttons[41].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "43":
                        buttons[42].Enabled = false;
                        buttons[42].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "44":
                        buttons[43].Enabled = false;
                        buttons[43].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "45":
                        buttons[44].Enabled = false;
                        buttons[44].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "46":
                        buttons[45].Enabled = false;
                        buttons[45].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "47":
                        buttons[46].Enabled = false;
                        buttons[46].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "48":
                        buttons[47].Enabled = false;
                        buttons[47].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "49":
                        buttons[48].Enabled = false;
                        buttons[48].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "50":
                        buttons[49].Enabled = false;
                        buttons[49].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "51":
                        buttons[50].Enabled = false;
                        buttons[50].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "52":
                        buttons[51].Enabled = false;
                        buttons[51].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                    case "53":
                        buttons[52].Enabled = false;
                        buttons[52].BackColor = Color.FromArgb(203, 237, 213);
                        break;
                }

            }  //make taken seats disable
            foreach (string s in sh.getMySeats(userName))
            {
                switch (s)
                {
                    case "1":
                        buttons[0].Enabled = false;
                        buttons[0].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "2":
                        buttons[1].Enabled = false;
                        buttons[1].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "3":
                        buttons[2].Enabled = false;
                        buttons[2].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "4":
                        buttons[3].Enabled = false;
                        buttons[3].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "5":
                        buttons[4].Enabled = false;
                        buttons[4].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "6":
                        buttons[5].Enabled = false;
                        buttons[5].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "7":
                        buttons[6].Enabled = false;
                        buttons[6].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "8":
                        buttons[7].Enabled = false;
                        buttons[7].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "9":
                        buttons[8].Enabled = false;
                        buttons[8].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "10":
                        buttons[9].Enabled = false;
                        buttons[9].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "11":
                        buttons[10].Enabled = false;
                        buttons[10].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "12":
                        buttons[11].Enabled = false;
                        buttons[11].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "13":
                        buttons[12].Enabled = false;
                        buttons[12].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "14":
                        buttons[13].Enabled = false;
                        buttons[13].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "15":
                        buttons[14].Enabled = false;
                        buttons[14].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "16":
                        buttons[15].Enabled = false;
                        buttons[15].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "17":
                        buttons[16].Enabled = false;
                        buttons[16].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "18":
                        buttons[17].Enabled = false;
                        buttons[17].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "19":
                        buttons[18].Enabled = false;
                        buttons[18].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "20":
                        buttons[19].Enabled = false;
                        buttons[19].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "21":
                        buttons[20].Enabled = false;
                        buttons[20].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "22":
                        buttons[21].Enabled = false;
                        buttons[21].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "23":
                        buttons[22].Enabled = false;
                        buttons[22].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "24":
                        buttons[23].Enabled = false;
                        buttons[23].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "25":
                        buttons[24].Enabled = false;
                        buttons[24].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "26":
                        buttons[25].Enabled = false;
                        buttons[25].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "27":
                        buttons[26].Enabled = false;
                        buttons[26].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "28":
                        buttons[27].Enabled = false;
                        buttons[27].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "29":
                        buttons[28].Enabled = false;
                        buttons[28].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "30":
                        buttons[29].Enabled = false;
                        buttons[29].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "31":
                        buttons[30].Enabled = false;
                        buttons[30].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "32":
                        buttons[31].Enabled = false;
                        buttons[31].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "33":
                        buttons[32].Enabled = false;
                        buttons[32].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "34":
                        buttons[33].Enabled = false;
                        buttons[33].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "35":
                        buttons[34].Enabled = false;
                        buttons[34].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "36":
                        buttons[35].Enabled = false;
                        buttons[35].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "37":
                        buttons[36].Enabled = false;
                        buttons[36].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "38":
                        buttons[37].Enabled = false;
                        buttons[37].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "39":
                        buttons[38].Enabled = false;
                        buttons[38].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "40":
                        buttons[39].Enabled = false;
                        buttons[39].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "41":
                        buttons[40].Enabled = false;
                        buttons[40].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "42":
                        buttons[41].Enabled = false;
                        buttons[41].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "43":
                        buttons[42].Enabled = false;
                        buttons[42].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "44":
                        buttons[43].Enabled = false;
                        buttons[43].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "45":
                        buttons[44].Enabled = false;
                        buttons[44].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "46":
                        buttons[45].Enabled = false;
                        buttons[45].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "47":
                        buttons[46].Enabled = false;
                        buttons[46].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "48":
                        buttons[47].Enabled = false;
                        buttons[47].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "49":
                        buttons[48].Enabled = false;
                        buttons[48].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "50":
                        buttons[49].Enabled = false;
                        buttons[49].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "51":
                        buttons[50].Enabled = false;
                        buttons[50].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "52":
                        buttons[51].Enabled = false;
                        buttons[51].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                    case "53":
                        buttons[52].Enabled = false;
                        buttons[52].BackColor = Color.FromArgb(67, 154, 151);
                        break;
                }

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

