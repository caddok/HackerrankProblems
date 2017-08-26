using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputElements = readElementsInput();
            int result = sumArrayElements(inputElements);
            Console.WriteLine(result);
        }

        private static IEnumerable<int> readElementsInput()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            return ar_temp.Select(number => Convert.ToInt32(number));
        }

        private static int sumArrayElements(IEnumerable<int> elements)
        {
            int sum = 0;
            foreach (var number in elements)
            {
                sum += number;
            }
            return sum;
        }
    }
}
