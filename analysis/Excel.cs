using Bytescout.Spreadsheet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final
{
    internal class Excel
    {
        string path = "../../../Database/Book2.xlsx";
        int row;
        Spreadsheet sh = new Spreadsheet();
        Worksheet ws;
        public Excel( string sheetName)
        {
            sh.LoadFromFile(@path);
            ws = sh.Workbook.Worksheets.ByName(sheetName);
            row = -1;
        }
        public bool getPass(string user,string pass)
        {
            int r = 0, c = 0;

            while (ws.Cell(r, c).Value != null)
            {

                if (ws.Cell(r, c).Value.ToString() == user.ToLower())
                {
                     if(ws.Cell(r, c + 1).Value.ToString() == pass)
                     {
                        return true;
                     }
                }

                r++;
            }

            return false;
        }

        public void addNewUser(User user)
        {
            string userName = user.Username.Trim().ToLower();
            string password = user.Password.Trim();
            if (ifExist(userName))
            {
                MessageBox.Show("already have an account! \n try login or use another user name for register");
                return;
            }
            if (userName == string.Empty || password == string.Empty)
            {
                MessageBox.Show("user name and password must not be empty");
                return;
            }


            row++;

            ws.Rows.Insert(row, 1);
            // Set values
            ws.Rows[row][0].Value = userName;
            ws.Rows[row][1].Value = password;

            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();

        }
        bool ifExist(string user)
        {
            int r = 0, c = 0;

            while (ws.Cell(r, c).Value != null)
            {

                if (ws.Cell(r, c).Value.ToString() == user.ToLower())
                {
                    return true;
                }

                r++;
            }

            return false;
        }
        public void changePass(string user, string newPass)
        {
            //checkValidation(user, newPass);
            if (newPass == string.Empty)
            {
                MessageBox.Show("user name and password must not be empty");
                return;
            }
            int r = 0, c = 0;

            while (ws.Cell(r, c).Value != null)
            {

                if (ws.Cell(r, c).Value.ToString() == user.ToLower())
                {
                    ws.Cell(r, c + 1).Value = newPass;
                    if (File.Exists(@path))
                    {
                        File.Delete(@path);
                    }
                    sh.SaveAs(@path);
                    sh.Close();
                    return;
                }

                r++;
            }
            return;
        }
        public void saveSeats(int numSeat, string user)
        {
            //removeMySeats(user);

            ws.Rows.Insert(0, 1);
            // Set values
            ws.Rows[0][0].Value = numSeat;
            ws.Rows[0][1].Value = user;
            //seatsTaken++;
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();
        }
        public void removeMySeats(string user)
        {
            int row = 0;
            while ((ws.Cell(row, 1).Value != null))
            {
                if (ws.Cell(row, 1).Value.ToString() == user)
                {
                    ws.Rows.Delete(row);
                }
                else
                {
                    row++;
                }

            }
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();
        }   //remove current user seats taken from the excel sheet
            //u will use this function in accout button الغاء الحجز

        public void removeAllSeats()
        {

            while ((ws.Cell(0, 0).Value != null))
            {
                ws.Rows.Delete(0, 1);
            }
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();
        } //remove all seats
          //use in trip setting new trip button
        public List<string> getAllSeats()
        {
            int  r = 0;

            List<string> strings = new List<string>();
            while (ws.Cell(r, 0).Value != null)
            {
                strings.Add( ws.Cell(r, 0).Value.ToString());
                r++;
            }
            return strings;
        } //return array of strings of seats taken
        public List<string> getMySeats(string user)
        {
            int  r = 0;

            
            List<string> strings = new List<string>();
            
            while (ws.Cell(r, 1).Value != null)
            {
                if (ws.Cell(r, 1).Value.ToString() == user)
                {
                    strings.Add(ws.Cell(r, 0).Value.ToString());
                    
                }
                r++;
            }
            return strings;
        } //return array of string of current user seats

        public void storeTripSetting(string[] arr)
        {

            int row = 0;
            while ((ws.Cell(row, 0).Value != null))
            {
                if (ws.Cell(row, 0).Value.ToString() == arr[0])
                {
                    MessageBox.Show("Already exist");
                    return;
                }
                row++;
            }
            ws.Rows.Insert(0, 1);
            // Set values
            ws.Rows[0][0].Value = arr[0]; // trip name
            ws.Rows[0][1].Value = arr[1]; // date
            ws.Rows[0][2].Value = arr[2]; // destination
            ws.Rows[0][3].Value = arr[3]; // bus number
            ws.Rows[0][4].Value = arr[4]; // driver name
            ws.Rows[0][5].Value = arr[5]; // time
            ws.Rows[0][6].Value = arr[6]; // location
            ws.Rows[0][7].Value = arr[7]; // price
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();

        }
        public void removeTrip(string s)
        {
            int row = 0;
            while ((ws.Cell(row, 0).Value != null))
            {
                if (ws.Cell(row, 0).Value.ToString() == s)
                {
                    ws.Rows.Delete(row);
                    if (File.Exists(@path))
                    {
                        File.Delete(@path);
                    }
                    sh.SaveAs(@path);
                    sh.Close();
                    return;
                }
                row++;

            }
        }  //function that take trip name and remove it from excel
        public string[] getTripSetting(string s)
        {
            string[] arr = { " ", " ", " ", " ", " ", " ", " ", " " };
            int row = 0;
            while ((ws.Cell(row, 0).Value != null))
            {
                if (ws.Cell(row, 0).Value.ToString() == s)
                {
                    arr[0] = ws.Cell(row, 0).Value.ToString();
                    arr[1] = ws.Cell(row, 1).Value.ToString();
                    arr[2] = ws.Cell(row, 2).Value.ToString();
                    arr[3] = ws.Cell(row, 3).Value.ToString();
                    arr[4] = ws.Cell(row, 4).Value.ToString();
                    arr[5] = ws.Cell(row, 5).Value.ToString();
                    arr[6] = ws.Cell(row, 6).Value.ToString();
                    arr[7] = ws.Cell(row, 7).Value.ToString();

                    return arr;
                }
                row++;

            }
            MessageBox.Show("Trip not found");

            return arr;
        } //function that takes trip name and get the trip setting from excel
        public void storeCurrentTrip(string s)
        {
            ws.Cell("A1").Value = s;
            if (File.Exists(@path))
            { 
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();
        }
        public string getCurrentTrip()
        {
            return ws.Cell(0, 0).Value.ToString();
            
        }
        public List<string> gettripNames()
        {
            int row = 0;

            while ((ws.Cell(row, 0).Value != null))
            {

                row++;
            }
            List<string> s = new List<string>();
            row = 0;
            while ((ws.Cell(row, 0).Value != null))
            {
                s.Add(ws.Cell(row, 0).Value.ToString());
                row++;
            }
            return s;

        }
    }

}
//public void saveNumOfSeatsAvailable(int s)
//{
//    ws.Cell("E1").Value = s.ToString();
//    if (File.Exists(@path))
//    {
//        File.Delete(@path);
//    }
//    sh.SaveAs(@path);
//    sh.Close();
//}



//public int getSeatsAvailable()
//{
//    return int.Parse(ws.Cell("E1").Value.ToString());
//} //return number of seats available



// void checkValidation(string user,string pass)
//{
//    string userName = user.Trim();
//    string password = pass.Trim();
//    if (ifExist(userName))
//    {
//        MessageBox.Show("alreadu have an account! \n try login or use another user name for register");
//        return;
//    }
//    if (userName == string.Empty || password == string.Empty)
//    {
//        MessageBox.Show("user name and password must not be empty");
//        return;
//    }
//}
