using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class NumberWithSum
    {
        public static void FindNdigitNum(string result,int n ,int target)
        {
            if (n > 0 && target >= 0)
            {
                char d = '0';
                if (result.Equals(""))
                {  
                    d = '1';
                }

                while (d <= '9')
                {
                    FindNdigitNum(result + d, n - 1, target - (d - '0'));
                    d++;
                }
            }

            else if (n == 0 && target == 0)
            {
               Console.WriteLine(result + " ");
            }
        }
    }
}
