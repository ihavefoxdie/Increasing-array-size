using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practicing
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[1];
            
            while (true)
            {
                numbers[numbers.Length - 1] = Convert.ToInt32(Console.ReadLine());
                if (numbers[numbers.Length - 1] == -1)
                    break;
                int[] newNumbers = new int[numbers.Length + 1];
                numbers.CopyTo(newNumbers, 0);
                numbers = newNumbers;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}