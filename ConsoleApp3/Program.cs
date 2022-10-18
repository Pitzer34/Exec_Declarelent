using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //判斷9,202是奇偶數
            int number1 = 9 % 2;
            int number2 = 202 % 2;
            
            if(number1 == 1)
            {
                Console.WriteLine(number1+"是奇數");
            }
             else
            {
                Console.WriteLine(number1 + "是偶數");
            }

            if (number2 == 1)
            {
                Console.WriteLine(number2 + "是奇數");
            }
            else
            {
                Console.WriteLine(number2 + "是偶數");
            }

        }
    }
}
