using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJonsgaard2F1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if

            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            subtotal = decimal.Parse(input);
            if (subtotal >= 100)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2 if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            discountPercent = 0m;
            subtotal = decimal.Parse(input);
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2"); ;
            }
            return status;
       
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4: if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5: Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6: nested if statements
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else        // customerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            //#7 Validate input: non-empty string
            decimal ethereum = 0m;

            if (input != "")
            {
                decimal dollars = decimal.Parse(input);
                ethereum = 200m * dollars;
             return ethereum.ToString("n2");

            }
            return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal Total = 0m;
            if (inputA != "" && inputB != "")
            {
               
                                
                                   

                decimal dollars = decimal.Parse(inputA);
                decimal Quantity = decimal.Parse(inputB);
                decimal Shipping = 0m;
                Shipping = Quantity * dollars;
                {
                    if (Shipping < 50)
                        Total = Shipping + 5;
                    else if (Shipping >= 50)
                        Total = Shipping;
                    return Total.ToString("n2");
                }
                

            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            if (inputA != "" && inputB != "") 
            {
                decimal lastMonth = decimal.Parse(inputA);
                decimal currentMonth = decimal.Parse(inputB);
                decimal cost = 0m;
                decimal hours = 0m;
                if (lastMonth < currentMonth)
                {
                    if (currentMonth > lastMonth)
                        hours = currentMonth - lastMonth;
                    cost = hours * .1m;
                    return cost.ToString("n2");
                }

            }
                return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            // Both numbers must be > 0
            if (inputA != "" && inputB != "")
            {
                decimal box1 = decimal.Parse(inputA);
                decimal box2 = decimal.Parse(inputB);
                decimal total = 0m;
                if (box1 != 0 && box2 != 0)
                {
                    if (box1 <= box2)
                        total = box2 / box1;
                    if (box2 <= box1)
                        total = box1 / box2;
                    return total.ToString("n2");
                }
            }
                return "Invalid input";
        }
    }
}
