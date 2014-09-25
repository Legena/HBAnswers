using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAnswers
{
    class Program
    {
        public static bool ExOh(string str)
        {
            int exCount = 0;
            int ohCount = 0;
            foreach (char ch in str)
            {
                if (ch == 'o')
                    ohCount++;
                else
                    exCount++;
            }

            if (exCount == ohCount)
                return true;
            else
                return false;
        }


        public static bool ABCheck(string str)
        {
            for (int i = 0; i < str.Length - 4; i++)
            {
                if (str[i] == 'a')
                {
                    if (str[i + 4] == 'b')
                    {
                        return true;
                    }
                }

                else if (str[i] == 'b')
                {
                    if (str[i + 4] == 'a')
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public static string DashInsert(int num)
        {
            string result = "";
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length - 1; i++)
            {
                result += numStr[i];
                if ((numStr[i] % 2) == 1)
                {
                    if ((numStr[i + 1] % 2) == 1)
                    {
                        result += '-';
                    }
                }
            }

            result += numStr.Last();

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ExOh("xoxoox"));

            Console.WriteLine(ExOh("oooxoo"));

            Console.WriteLine(ABCheck("after badly"));

            Console.WriteLine(ABCheck("Laura sobs"));

            Console.WriteLine(DashInsert(99946));

            Console.WriteLine(DashInsert(56730));
        }
    }
}
