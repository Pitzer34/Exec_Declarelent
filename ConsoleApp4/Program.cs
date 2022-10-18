using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //根據兩變數大小,視需要對調兩變數

            int number1 = 10;
            int number2 = 20;

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"對調的結果:number1={number1},number2={number2}");
        }
    }
}
