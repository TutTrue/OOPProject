using Bytescout.Spreadsheet.COM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytescout.Spreadsheet;
using Microsoft.Office;
using System.Reflection.Metadata;
using Bytescout.Spreadsheet.BaseClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace Final
{
     internal class Excel
    {
        public string path { get;}
        int row;
        //int seatsTaken ;
        Spreadsheet sh = new Spreadsheet();
        Worksheet ws;
        public Excel(string path, string sheetName)
        {
            this.path = path;
            sh.LoadFromFile(path);
            ws = sh.Workbook.Worksheets.ByName(sheetName);
            row = -1;
            //seatsTaken = 0;
        }
        public string? getPass(string user)
        {
            int r = 0, c = 0;

            while (ws.Cell(r, c).Value != null)
            {

                if (ws.Cell(r, c).Value.ToString() == user.ToLower())
                {
                    //if (ws.Cell(r, c + 1).Value.ToString() is null)
                    //    return "";
                    
                    
                    return ws.Cell(r, c + 1).Value.ToString();
                }

                r++;
            }

            return null;
        }
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

            //ws.Cell(row, 0).Value = userName;
            //ws.Cell(row, 1).Value = password;
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
        public void changePass(string user,string newPass) 
        {
            //checkValidation(user, newPass);
            if ( newPass == string.Empty)
            {
                MessageBox.Show("user name and password must not be empty");
                return;
            }
            int r = 0, c = 0;

            while (ws.Cell(r, c).Value != null)
            {

                if (ws.Cell(r, c).Value.ToString() == user.ToLower())
                {
                    //if (ws.Cell(r, c + 1).Value.ToString() is null)
                    //    return "";


                    ws.Cell(r, c + 1).Value=newPass;
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
        public void saveSeats(int numSeat,string user)
        {
            int row = 0;
            ws.Rows.Insert(row, 1);
            // Set values
            ws.Rows[row][0].Value = numSeat;
            ws.Rows[row][1].Value = user;
            //seatsTaken++;

            //ws.Cell(row, 0).Value = userName;
            //ws.Cell(row, 1).Value = password;
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }
            sh.SaveAs(@path);
            sh.Close();
        }
        public string[] getSeats()
        {
            int counter = 0, r = 0, c = 0 ;
            
            while (ws.Cell(r, c).Value != null)
            {
                counter++;
                r++;
            }
            string[] strings = new string[counter];
            for (int i = 0; i < counter; i++)
            {
                strings[i] = ws.Cell(i, 0).Value.ToString();
            }
            return strings;
        }
        public string[] getMySeats(string user)
        {
            int counter = 0, r = 0, c = 1,r1=0;

            while (ws.Cell(r, c).Value != null)
            {
                if (ws.Cell(r, c).Value.ToString() ==user)
                {
                    counter++;
                }
                r++;
            }
            string[] strings = new string[counter];
            int i = 0;
            while (ws.Cell(r1, c).Value != null)
            {
                if (ws.Cell(r1, c).Value.ToString() == user)
                {
                    strings[i] = ws.Cell(r1, c-1).Value.ToString();
                    i++;
                }
                r1++;
            }
            return strings;
        }
    }
}
