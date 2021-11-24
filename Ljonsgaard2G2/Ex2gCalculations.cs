using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljonsgaard2G2
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            // 1a) "Switch with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;


            }

            return discountPercent.ToString("0.0");
        }
        public static string If01(string customerType)
        {
            // 1b) Seprate "if" statements
            decimal discountPercent = -.1m;

            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;

            return discountPercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            // 1c) if elseIf
            decimal discountPercent = -1.0m;

            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;

            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse01(string customerType)
        {
            // 1d) Nested if-else
            decimal discountPercent = -.1m;

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
            }

            return discountPercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customerType)
        {
            // 1e) "Switch with default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = .0m;
                    break;


            }

            return discountPercent.ToString("0.0");
        }

        public static string IfDefault01(string customerType)
        {
            // 1f) Seprate "if" statements, default value
            decimal discountPercent = -.1m;

            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType != "R" && customerType != "C")
                discountPercent = .0m;

            return discountPercent.ToString("0.0");
        }
        public static string ElseIfDefault01(string customerType)
        {
            // 1g) if elseIf with default
            decimal discountPercent = -.1m;

            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            else
                discountPercent = .0m;

            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElseDefault01(string customerType)
        {
            // 1h) Nested if-else with Default
            decimal discountPercent = -.1m;

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                {
                    discountPercent = .0m;
                }
            }

            return discountPercent.ToString("0.0");

        }
        public static string Switch02(string customerType)
        {
            // 2a) 'Switch' with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                case "C":
                    discountPercent = .2m;
                    break;
                case "!":
                    discountPercent = .4m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string If02(string customerType)
        {
            // 2b) Separate 'if' statements
            decimal discountPercent = -.1m;

            if (customerType == "R")
                discountPercent = .2m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType == "T")
                discountPercent = .4m;
            if (customerType != "R" && customerType != "C" && customerType != "T")
                    discountPercent = -1.0m;

            return discountPercent.ToString("0.0");
        }
        public static string ElseIf02(string customerType)
        {
            // 2c) if elseif            
            decimal discountPercent = -.1m;

            if (customerType == "R")
                discountPercent = .2m;
            else if (customerType == "C")
                discountPercent = .2m;
            else
                discountPercent = .4m;

            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse02(string customerType)
        {
            // 2d) Nested if-else
            decimal discountPercent = -.1m;

            if (customerType == "R")
            {
                discountPercent = .2m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                {
                    discountPercent = .4m;
                }
            }

            return discountPercent.ToString("0.0");
        }
    }
}
