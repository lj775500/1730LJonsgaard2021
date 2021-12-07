using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LJonsgaard3b1;

namespace LJonsgaard3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static decimal CalculateFutureValue(decimal monthlyInvesmet, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;

            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvesmet) * (1 + monthlyInterestRate);

            }

            return futureValue;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double Celsius = 0;
            string f = fahrenheit.ToString();
            if (f != "")
            {
                Celsius = (fahrenheit - 32) / 1.8;
            }
            return Celsius;

        }
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0; 
            return total;


        }

    }
}
