using System;
using System.Collections.Generic;
using System.Linq;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 0;
            while (true)
            {
                Console.WriteLine("Digite um número:");
                num = int.Parse(Console.ReadLine());
                if (num == 0) break;
                Console.WriteLine(HappyNumber(num));
            }
        }

        public static string HappyNumber(double num)
        {
            var auxList = new List<double>();

            while (num != 1 && !auxList.Contains(num))
            {
                auxList.Add(num);
                num = num.ToString().Sum(c => Math.Pow(double.Parse(c.ToString()), 2));
            }

            return num == 1
                ? "Feliz"
                : "Triste";
        }
    }
}
