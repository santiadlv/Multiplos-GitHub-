using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiplosDeDiez.Clases
{
    class readFromFile
    {
        public static List<string> stringList;
        public static void numbers()
        {
            stringList = File.ReadAllLines(@"D:\santi\Microsoft Visual Studio Community\VS Projects\Segundo Semestre\POO\Prácticas\Multiplos (GitHub)\numbers.txt").ToList();
            foreach (string line in stringList) //Remember to replace the above directory with the one that holds
            {                                   //the file in your local computer's drive.
                Console.WriteLine(line);
            }
        }
    }
}
