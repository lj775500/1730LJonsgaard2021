using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJonsgaard3C
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string day = "Invalid index";
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (index <= 7 && index >= 1)
            {
                index -= 1;
                day = days[index];

            }
            return day;
        }

        public static string Calc1(string day)
        {
            try
            {
                day = day.Trim();
                day = day.ToUpper();
                string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
                string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
                int index = Array.IndexOf(days, day);
                string Hours = hours[index];
                return Hours;
            }
            catch
            {
            }
            return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            if (count <= 5 || count == 0.0)
            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
            }
            return sum;
        }
        public static double Calc4(double[] numbers)
        {
            double sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
                sum = sum + numbers[i];
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            sum /= numbers.Length;
            return sum;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double number in numbers)
                {
                    if (number >= avg)
                        aboveAvgList.Add(number);
                }
            }
            return aboveAvgList.ToArray();
        }
    }
}