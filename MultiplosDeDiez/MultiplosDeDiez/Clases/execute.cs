using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeDiez.Clases
{
    class execute
    {
        public static void exec()
        {
            Console.WriteLine("Original text file:\n");
            readFromFile.numbers();
            convToInt.numConversion();
            Console.WriteLine("\nThe quantity of numbers that are divisible by 10 is: {0}.", checkNum.checker());
        }
    }
}
