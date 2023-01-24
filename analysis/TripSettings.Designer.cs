namespace Final
{
    partial class TripSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeComboBox = new System.Windows.Forms.ComboBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Hour = new System.Windows.Forms.TextBox();
            this.DestinationComboBox = new System.Windows.Forms.ComboBox();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BusEdit = new System.Windows.Forms.TextBox();
            this.PriceEdit = new System.Windows.Forms.TextBox();
            this.DriverTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.Label();
            this.Bus = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Driver = new System.Windows.Forms.Label();
            this.TripName = new System.Windows.Forms.Label();
            this.removeTripbtn = new System.Windows.Forms.Button();
            this.reset_trip = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ChangeTrip = new System.Windows.Forms.ComboBox();
            this.removeTriptxtbox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(583, 474);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(205, 42);
            this.clear.TabIndex = 27;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(832, 406);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(205, 42);
            this.AddBtn.TabIndex = 28;
            this.AddBtn.Text = "Add Trip";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TimeComboBox);
            this.groupBox1.Controls.Add(this.Min);
            this.groupBox1.Controls.Add(this.Hour);
            this.groupBox1.Controls.Add(this.DestinationComboBox);
            this.groupBox1.Controls.Add(this.LocationComboBox);
            this.groupBox1.Controls.Add(this.DateTimePicker);
            this.groupBox1.Controls.Add(this.BusEdit);
            this.groupBox1.Controls.Add(this.PriceEdit);
            this.groupBox1.Controls.Add(this.DriverTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.Destination);
            this.groupBox1.Controls.Add(this.Bus);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.Location);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.Driver);
            this.groupBox1.Controls.Add(this.TripName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.groupBox1.Location = new System.Drawing.Point(101, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(936, 346);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Addition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(693, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.TimeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeComboBox.ForeColor = System.Drawing.Color.Black;
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Items.AddRange(new object[] {
            "PM",
            "AM"});
            this.TimeComboBox.Location = new System.Drawing.Point(781, 129);
            this.TimeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(68, 37);
            this.TimeComboBox.TabIndex = 27;
            this.TimeComboBox.Text = "PM";
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.Control;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Min.ForeColor = System.Drawing.Color.Black;
            this.Min.Location = new System.Drawing.Point(715, 129);
            this.Min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(45, 35);
            this.Min.TabIndex = 26;
            this.Min.Text = "00";
            this.Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Min_KeyPress);
            // 
            // Hour
            // 
            this.Hour.BackColor = System.Drawing.SystemColors.Control;
            this.Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hour.ForeColor = System.Drawing.Color.Black;
            this.Hour.Location = new System.Drawing.Point(642, 129);
            this.Hour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(45, 35);
            this.Hour.TabIndex = 25;
            this.Hour.Text = "00";
            this.Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hour_KeyPress);
            // 
            // DestinationComboBox
            // 
            this.DestinationComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.DestinationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DestinationComboBox.ForeColor = System.Drawing.Color.Black;
            this.DestinationComboBox.FormattingEnabled = true;
            this.DestinationComboBox.Items.AddRange(new object[] {
            "Cairo",
            "Alex",
            "Ismaili"});
            this.DestinationComboBox.Location = new System.Drawing.Point(187, 186);
            this.DestinationComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DestinationComboBox.Name = "DestinationComboBox";
            this.DestinationComboBox.Size = new System.Drawing.Size(249, 28);
            this.DestinationComboBox.TabIndex = 24;
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.LocationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationComboBox.ForeColor = System.Drawing.Color.Black;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Items.AddRange(new object[] {
            "Dokki",
            "Abu Qir",
            "Corniche Ismaili"});
            this.LocationComboBox.Location = new System.Drawing.Point(642, 190);
            this.LocationComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(249, 28);
            this.LocationComboBox.TabIndex = 23;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Tai Le", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(182)))), ((int)(((byte)(183)))));
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker.Location = new System.Drawing.Point(186, 127);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateTimePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(250, 24);
            this.DateTimePicker.TabIndex = 22;
            // 
            // BusEdit
            // 
            this.BusEdit.BackColor = System.Drawing.SystemColors.Control;
            this.BusEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BusEdit.ForeColor = System.Drawing.Color.Black;
            this.BusEdit.Location = new System.Drawing.Point(186, 242);
            this.BusEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BusEdit.Name = "BusEdit";
            this.BusEdit.Size = new System.Drawing.Size(249, 35);
            this.BusEdit.TabIndex = 20;
            // 
            // PriceEdit
            // 
            this.PriceEdit.BackColor = System.Drawing.SystemColors.Control;
            this.PriceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceEdit.ForeColor = System.Drawing.Color.Black;
            this.PriceEdit.Location = new System.Drawing.Point(642, 242);
            this.PriceEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceEdit.Name = "PriceEdit";
            this.PriceEdit.Size = new System.Drawing.Size(249, 35);
            this.PriceEdit.TabIndex = 21;
            this.PriceEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceEdit_KeyPress);
            // 
            // DriverTextBox
            // 
            this.DriverTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DriverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DriverTextBox.ForeColor = System.Drawing.Color.Black;
            this.DriverTextBox.Location = new System.Drawing.Point(642, 66);
            this.DriverTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DriverTextBox.Name = "DriverTextBox";
            this.DriverTextBox.Size = new System.Drawing.Size(249, 35);
            this.DriverTextBox.TabIndex = 19;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameTextBox.Location = new System.Drawing.Point(186, 66);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(249, 35);
            this.NameTextBox.TabIndex = 18;
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Destination.ForeColor = System.Drawing.Color.CadetBlue;
            this.Destination.Location = new System.Drawing.Point(38, 180);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(132, 30);
            this.Destination.TabIndex = 16;
            this.Destination.Text = "Destination:";
            // 
            // Bus
            // 
            this.Bus.AutoSize = true;
            this.Bus.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bus.ForeColor = System.Drawing.Color.CadetBlue;
            this.Bus.Location = new System.Drawing.Point(38, 243);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(142, 30);
            this.Bus.TabIndex = 15;
            this.Bus.Text = "Bus Number:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.ForeColor = System.Drawing.Color.CadetBlue;
            this.Time.Location = new System.Drawing.Point(498, 129);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(67, 30);
            this.Time.TabIndex = 14;
            this.Time.Text = "Time:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.Color.CadetBlue;
            this.Price.Location = new System.Drawing.Point(498, 253);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(67, 30);
            this.Price.TabIndex = 13;
            this.Price.Text = "Price:";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Location.ForeColor = System.Drawing.Color.CadetBlue;
            this.Location.Location = new System.Drawing.Point(498, 194);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(104, 30);
            this.Location.TabIndex = 12;
            this.Location.Text = "Location:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date.ForeColor = System.Drawing.Color.CadetBlue;
            this.Date.Location = new System.Drawing.Point(38, 124);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(64, 30);
            this.Date.TabIndex = 11;
            this.Date.Text = "Date:";
            // 
            // Driver
            // 
            this.Driver.AutoSize = true;
            this.Driver.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Driver.ForeColor = System.Drawing.Color.CadetBlue;
            this.Driver.Location = new System.Drawing.Point(498, 68);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(142, 30);
            this.Driver.TabIndex = 17;
            this.Driver.Text = "Driver Name:";
            // 
            // TripName
            // 
            this.TripName.AutoSize = true;
            this.TripName.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TripName.ForeColor = System.Drawing.Color.CadetBlue;
            this.TripName.Location = new System.Drawing.Point(38, 68);
            this.TripName.Name = "TripName";
            this.TripName.Size = new System.Drawing.Size(120, 30);
            this.TripName.TabIndex = 10;
            this.TripName.Text = "Trip Name:";
            // 
            // removeTripbtn
            // 
            this.removeTripbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.removeTripbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTripbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.removeTripbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTripbtn.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeTripbtn.ForeColor = System.Drawing.Color.White;
            this.removeTripbtn.Location = new System.Drawing.Point(101, 474);
            this.removeTripbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeTripbtn.Name = "removeTripbtn";
            this.removeTripbtn.Size = new System.Drawing.Size(205, 42);
            this.removeTripbtn.TabIndex = 27;
            this.removeTripbtn.Text = "Remove trip";
            this.removeTripbtn.UseVisualStyleBackColor = false;
            this.removeTripbtn.Click += new System.EventHandler(this.removeTripbtn_Click);
            // 
            // reset_trip
            // 
            this.reset_trip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.reset_trip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_trip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.reset_trip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_trip.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset_trip.ForeColor = System.Drawing.Color.White;
            this.reset_trip.Location = new System.Drawing.Point(101, 408);
            this.reset_trip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset_trip.Name = "reset_trip";
            this.reset_trip.Size = new System.Drawing.Size(205, 42);
            this.reset_trip.TabIndex = 29;
            this.reset_trip.Text = "Change Current Trip";
            this.reset_trip.UseVisualStyleBackColor = false;
            this.reset_trip.Click += new System.EventHandler(this.reset_trip_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(832, 474);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(205, 42);
            this.Back.TabIndex = 30;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(154)))), ((int)(((byte)(151)))));
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(128)))), ((int)(((byte)(125)))));
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Nirmala UI", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(583, 408);
            this.Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(205, 42);
            this.Reset.TabIndex = 31;
            this.Reset.Text = "Reset Trip";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ChangeTrip
            // 
            this.ChangeTrip.BackColor = System.Drawing.SystemColors.Control;
            this.ChangeTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeTrip.ForeColor = System.Drawing.Color.Black;
            this.ChangeTrip.FormattingEnabled = true;
            this.ChangeTrip.Location = new System.Drawing.Point(312, 415);
            this.ChangeTrip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeTrip.Name = "ChangeTrip";
            this.ChangeTrip.Size = new System.Drawing.Size(249, 30);
            this.ChangeTrip.TabIndex = 32;
            // 
            // removeTriptxtbox
            // 
            this.removeTriptxtbox.BackColor = System.Drawing.SystemColors.Control;
            this.removeTriptxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeTriptxtbox.ForeColor = System.Drawing.Color.Black;
            this.removeTriptxtbox.FormattingEnabled = true;
            this.removeTriptxtbox.Location = new System.Drawing.Point(312, 480);
            this.removeTriptxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeTriptxtbox.Name = "removeTriptxtbox";
            this.removeTriptxtbox.Size = new System.Drawing.Size(249, 30);
            this.removeTriptxtbox.TabIndex = 33;
            // 
            // TripSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1139, 550);
            this.Controls.Add(this.removeTriptxtbox);
            this.Controls.Add(this.ChangeTrip);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.reset_trip);
            this.Controls.Add(this.removeTripbtn);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TripSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripSettings";
            this.Load += new System.EventHandler(this.TripSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button clear;
        private Button AddBtn;
        private Label Destination;
        private Label Bus;
        private Label Time;
        private Label Price;
        private Label Location;
        private Label Date;
        private Label Driver;
        private Label TripName;
        public GroupBox groupBox1;
        public Label label7;
        public ComboBox TimeComboBox;
        public TextBox Min;
        public TextBox Hour;
        public ComboBox DestinationComboBox;
        public ComboBox LocationComboBox;
        public DateTimePicker DateTimePicker;
        public TextBox BusEdit;
        public TextBox PriceEdit;
        public TextBox DriverTextBox;
        public TextBox NameTextBox;
        private Button removeTripbtn;
        private Button reset_trip;
        private Button Back;
        private Button Reset;
        public ComboBox ChangeTrip;
        public ComboBox removeTriptxtbox;
    }
}