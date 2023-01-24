namespace Final
{
    public partial class Welcome_page : UserControl
    {
        Excel sh = new Excel(@"../../../Database/Book2.xlsx", "seats");
        Excel tripWorkbook = new Excel(@"../../../Database/Book2.xlsx", "tripSetting");
        Excel currentTrip = new Excel(@"../../../Database/Book2.xlsx", "CurrentTrip");

        public string tripName;

        public Welcome_page()
        {
            InitializeComponent();
            tripName = currentTrip.getCurrentTrip();
        }


        private void Welcome_page_Load(object sender, EventArgs e)
        {
            string[] tripSetting = tripWorkbook.getTripSetting(currentTrip.getCurrentTrip());
            Name_Trip.Text = tripSetting[0];
            datelbl.Text = tripSetting[1];
            label2.Text += tripSetting[2];
            busNumberlbl.Text = tripSetting[3];
            driverName.Text = tripSetting[4];
            timelbl.Text = tripSetting[5];
            Gatheringlbl.Text = tripSetting[6];
            ticketPricelbl.Text = tripSetting[7];
        }
    }
}



//order of strings'array from excel
//string[] s =
//{
//    NameTextBox.Text,
//    DateTimePicker.Text,
//    DestinationComboBox.Text,
//    BusEdit.Text,
//    DriverTextBox.Text,
//    Hour.Text+" : "+Min.Text+" "+TimeComboBox.Text,
//    LocationComboBox.Text,
//    PriceEdit.Text
//};