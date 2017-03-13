using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.WriteLine("Input First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
