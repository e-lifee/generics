
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            int max1 = 0, min1 = 0;

            for (int i = 0; i < 20; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("array in order:");
            for(int i = 0; i < numbers.Length; i++) { 
            Console.WriteLine(numbers[i]);
        }

            int[] max = new int[3];
            for(int i = 0; i < 3; i++)
            {
                max[i] = numbers[i];
            }
            numbers.Reverse();
            int[] min = new int[3];
            for (int i = 0; i < 3; i++)
            {
                min[i] = numbers[numbers.Length-(i+1)];
            }
            Console.WriteLine("max array:");
            for (int i = 0; i < max.Length; i++)
            {
                Console.WriteLine(max[i]);
            }
            Console.WriteLine("min array:");
            for (int i = 0; i < min.Length; i++)
            {
                Console.WriteLine(min[i]);
            }

            for(int i = 0; i < max.Length; i++)
            {
                max1 += max[i];
            }
            Console.WriteLine("sum of max numbers=" + max1);
            for (int i = 0; i < min.Length; i++)
            {
                min1 += min[i];
            }
            Console.WriteLine("sum of min numbers=" + min1);

            int maxAv = (int)(max1 / max.Length);
            Console.WriteLine("average of max numbers=" + maxAv);

            int minAv = (int)(min1 / min.Length);
            Console.WriteLine("average of min numbers=" + minAv);
            Console.ReadLine();

            }
        
    }
}
