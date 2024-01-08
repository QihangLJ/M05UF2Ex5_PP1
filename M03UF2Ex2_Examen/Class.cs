using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03UF2Ex2_Examen
{
    internal class ExMenu
    {
        public static bool NaturalNumber(int num)
        {
            return num >= 0;
        }

        public static bool OddNumber(int num)
        {
            return num % 2 != 0;
        }
        public static int CalculatePower(int baseNum, int expNum)
        {
            int res = 1;

            for (int i = 0; i < expNum; i++)
            {
                res *= baseNum;
            }

            return res;
        }

        public static int RandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        public static int CountCharacter(string text)
        {
            char[] charArray = text.ToCharArray();
            int count = 0;
            for (int i = 0; i < charArray.Length;i++)
            {
                if (charArray[i] != ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
