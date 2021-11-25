using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace LJonsgaard2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {

                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {

                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            
            try
            {
                DateTime currentdate;
                currentdate = DateTime.Parse(strDateA);
                DateTime duedate;
                duedate = DateTime.Parse(strDateB);
                string days;

                TimeSpan timetilldue = currentdate - duedate;
                int daystilldue = timetilldue.Days;
                days = daystilldue.ToString() + " days";
                result = days.ToString();
            }
            catch { }


            return result;

        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";

            try
            {
                DateTime currentdate;
                currentdate = DateTime.Parse(strDateA);
                DateTime duedate;
                duedate = DateTime.Parse(strDateB);
                TimeSpan daystilldue;
                if (currentdate > duedate)
                {
                    daystilldue = currentdate - duedate;
                    int days = daystilldue.Days;
                    result = (days + " days past due");
                }
                else if (duedate == currentdate)
                {
                    result = "On time";
                }
                else if (duedate > currentdate)
                {
                    result = "On time";
                }
                return result;
            }
            catch { }


            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            string letter = s;
            letter = letter.Trim();
            if (letter.Length != 0 || s.Length == 0)
            {
                letter = letter.Remove(0, + 1);
                letter = letter.Insert(0, "c");
                letter = letter.Insert(1, "r");
                result = letter;
            }
            return result;
        }

        public static string StringCalc02(string s)
        {            
            string result = "Invalid input";
            string letter = s;
            letter = letter.Trim();
            if (letter.Length >= 2)
            {
                letter = letter.Remove(1, +1);
                letter = letter.Insert(1, "rit");
                result = letter;
            }
            return result;

        }


        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            string letter = s;
            letter = letter.Trim();
            if (letter.Length >= 6)
            {
                string word = letter.Substring(2, 4).ToUpper();
                
                result = word;
            }
            return result;

        }



        public static string StringCalc04(string s)
        {          
            string box = "";
            string letter = s;
            letter = letter.Trim();
            char pad = '*';
            box = letter.PadLeft(10, pad);
            return box;

        }




        public static string StringCalc05(string s)
        {
            s = s.Replace(" ", "");
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("-", "");
            return s;

        }





        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            s = s.Replace(" ", "");
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("-", "");
            int rlis = s.Length;
            if (rlis == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
            
            return s;
            }
            if (rlis == 7)
            {
                s = s.Insert(3, ".");
                return s;
            }
            return result;
        }






        public static string StringCalc07(string s)
        {
            string result = "Not Found";
            s = s.ToLower();
            if (s.Contains("pioneer"))
            {
                result = "Found";
            }
            return result;
        }







        public static string StringCalc08(string s)
        {
            string result = "Invalid Input";
            string address = s;
            address = address.Trim();
            
            if (address.IndexOf(",") >= 0)

            {
                int cityindex = address.IndexOf(",") + 1;
                string city = address.Substring(cityindex + 1);
                result = city;
            }
            return result;
        }








        public static string StringCalc09(string s)
        {
            string result = "Invalid Input";
            string address = s;
            address = address.Trim();

            if (address.LastIndexOf(" ") >= 0)

            {
                int zip = address.LastIndexOf(" ");
                string cityzip = address.Substring(zip + 1);
                result = cityzip;
            }
            return result;
        }









        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(s1 + ", ");
            sb.Append(s2 + ", ");
            sb.Append(s3);
            return sb.ToString();
        }
    }
}


    