using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJonsgaard2E1
{
    class LogicalOperations
    {
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
                }

        public static bool q02(int timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;
        }


        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true | counter++ < years;
        }
    }
}
