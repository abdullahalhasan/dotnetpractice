using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[]
            {
                5,10,36,15
            };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/

            Queue<int> aQueue =new Queue<int>();

            aQueue.Enqueue(100);
            aQueue.Enqueue(200);
            aQueue.Enqueue(150);

            Console.WriteLine(aQueue.Dequeue());
            Console.WriteLine(aQueue.Dequeue());
            Console.WriteLine(aQueue.Dequeue());
            Console.ReadKey();


        }
    }
}
