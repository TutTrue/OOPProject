namespace Final
{
    public partial class TripSettings : Form
    {
        public string userName;
        Excel sh = new Excel(@"../../../Database/Book2.xlsx", "seats");
        Excel tripWorkbook = new Excel(@"../../../Database/Book2.xlsx", "tripSetting");
        Excel currentTrip = new Excel(@"../../../Database/Book2.xlsx", "CurrentTrip");


        public TripSettings(string userName)
        {

            InitializeComponent();
            this.userName = userName;
        }
        //modify the trip in data base
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && DateTimePicker.Text != "" && DestinationComboBox.Text != ""
                && BusEdit.Text != "" && DriverTextBox.Text != "" && LocationComboBox.Text != "" && PriceEdit.Text != "")
            {

                string[] s =
                {
                NameTextBox.Text,
                DateTimePicker.Text,
                DestinationComboBox.Text,
                BusEdit.Text,
                DriverTextBox.Text,
                Hour.Text+" : "+Min.Text+" "+TimeComboBox.Text,
                LocationComboBox.Text,
                PriceEdit.Text

                };
                tripWorkbook.storeTripSetting(s); //store trip setting data in data base
                MessageBox.Show("Done");
                Main frm = new Main(userName);
                frm.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("These fields cant be null");
            }

        }
        //clear all text from text box
        private void clear_Click(object sender, EventArgs e)
        {
            PriceEdit.Text = "";
            NameTextBox.Text = "";
            DriverTextBox.Text = "";
            Hour.Text = "";
            Min.Text = "";
            TimeComboBox.Text = "";
            DestinationComboBox.Text = "";
            LocationComboBox.Text = "";
        }
        private void Hour_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void Min_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void PriceEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }
        //remove trip in text box from data base
        private void removeTripbtn_Click(object sender, EventArgs e)
        {
            if (removeTriptxtbox.Text == "")
                MessageBox.Show("please enter trip name");
            else
            {
                MessageBox.Show("Done");
                tripWorkbook.removeTrip(removeTriptxtbox.Text);
            }

        }
        //delete all seats from data base to new trip
        private void reset_trip_Click(object sender, EventArgs e)
        {
            if (ChangeTrip.Text != "")
            {
                currentTrip.storeCurrentTrip(ChangeTrip.Text);
                Main frm = new Main(userName);
                MessageBox.Show("Done");
                frm.Show();
                this.Hide();
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main frm = new Main(userName);
            frm.Show();
            this.Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            sh.removeAllSeats();
            MessageBox.Show("Done");
        }

        private void TripSettings_Load(object sender, EventArgs e)
        {
            List<string> tripSetting=tripWorkbook.gettripNames();
            foreach(string tripName in tripSetting)
            {
                this.ChangeTrip.Items.AddRange(new object[] {
                tripName });
                removeTriptxtbox.Items.AddRange(new object[]
                {
                    tripName
                });
            }
        }
    }
}






//this.ChangeTrip.Items.AddRange(new object[] {
//tripSetting[0],
//tripSetting[1],});