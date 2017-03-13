using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 int number sepatrating by pressing 'Enter': ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition result is "+add(firstNumber,secondNumber));
            Console.WriteLine("Substraction result is " + substract(firstNumber, secondNumber));

            Console.ReadKey();
        }

        static int add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int substract(int a, int b)
        {
            if (b>a)
            {
                int result= b-a;
                return result;
            }
            else
            {
                int result = a - b;
                return result;    
            }
            
        }
    }
}
