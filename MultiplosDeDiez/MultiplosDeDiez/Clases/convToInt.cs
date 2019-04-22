using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDeDiez.Clases
{
    class convToInt
    {
        public static List<int> numList = new List<int>();

        public static void numConversion()
        {
            for (int i = 0; i < readFromFile.stringList.Count; i++)
            {
                string[] temp = readFromFile.stringList[i].Split('\t');

                for (int p = 0; p < temp.Length; p++)
                {
                    int num = Convert.ToInt16(temp[p]);
                    numList.Add(num);
                }
            }
        }
    }
}
