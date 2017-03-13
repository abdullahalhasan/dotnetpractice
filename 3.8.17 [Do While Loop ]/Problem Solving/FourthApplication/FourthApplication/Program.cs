using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstArgument = 0;
            int secondArgument = 0;
            for (int i = 1; i <= 100; i++)
            {
                firstArgument += i*i;
                secondArgument += i;
            }
            int sqre = secondArgument*secondArgument;
            int finalResult = sqre - firstArgument;
            Console.WriteLine(finalResult);
            Console.ReadKey();
        }
    }
}
