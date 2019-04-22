using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeDiez.Clases
{
    class checkNum
    {
        public static int counter;

        public static int checker()
        {
            foreach (int currentNum in convToInt.numList)
            {
                if (currentNum % 10 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
