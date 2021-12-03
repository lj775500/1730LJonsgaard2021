using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace LJonsgaardex3A
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try { 
            int months = Int32.Parse(strMonths);
            double monthlysPayment = double.Parse(strMonthlyPayment);
            double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
            int i = 1;
            while (i <= months)
            {
                futureValue = (futureValue + monthlysPayment) * (1 + monthlyInterestRate);
                i++;
                }
            }
            catch 
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }
        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlysPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlysPayment) * (1 + monthlyInterestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlysPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= months; i++)
                
                {
                    futureValue = (futureValue + monthlysPayment) * (1 + monthlyInterestRate);
                    
                }
                
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            
            
            try
            {
                int increment = Int32.Parse(strIncrement);
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                string total = "";
                if (increment <= 0) throw new Exception();
                while (start < end)
                {
                    total += start + " ";
                    start += increment;
                    result = total;
                    
                }
                
            }
            catch
            {
                result = "Invalid input";
            }            
            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                string total = "";
                if (increment <= 0) throw new Exception();
                do
                {
                    total += start + " ";
                    start += increment;
                    result = total;
                }
                while (start < end);
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                string total = "";
                if (increment <= 0) throw new Exception();
                for (int S = start; S <= end; S += increment)
                    total += S + " ";
                return total;
            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "0";
            int startindex = 0;
            int total = 0;
            try
            {
                int count = Int32.Parse(strCount);
                while (count > 0)
                {
                    int endindex = strNumbers.IndexOf(' ', startindex);
                    string strNumber = strNumbers.Substring(startindex, endindex - startindex);
                    int number = Int32.Parse(strNumber);
                    total += number;
                    startindex = endindex;
                    startindex++;
                    count = count - 1;
                    result = total.ToString();
                }
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";
            int startindex = 0;
            int total = 0;
            try
            {
                int count = Int32.Parse(strCount);
                do
                {
                    int endindex = strNumbers.IndexOf(' ', startindex);
                    string strNumber = strNumbers.Substring(startindex, endindex - startindex);
                    int number = Int32.Parse(strNumber);
                    total += number;
                    startindex = endindex;
                    startindex++;
                    count = count - 1;
                    result = total.ToString();
                }
                while (count > 0);
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "0";            
            int startindex = 0;
            int total = 0;
            try
            {
                int count = Int32.Parse(strCount);
                string strnumber = "";
                for (int endindex = 0; count > 0;)
                {
                    endindex = strNumbers.IndexOf(' ', startindex);
                    strnumber = strNumbers.Substring(startindex, endindex - startindex);
                    int number = Int32.Parse(strnumber);
                    total += number;
                    startindex = endindex + 1;
                    count = count - 1;
                    result = total.ToString();
                }
                    

            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }
    }
}
