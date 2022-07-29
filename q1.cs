
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
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();
            int[] numbers = new int[20];
            try
            {

                for(int i = 0; i < 20; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int count = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0 || numbers[i] == 1)
                    {
                        count++;
                    }
                    else if (numbers[i] == 2)
                    {
                        count += 0;
                    }
                    else
                    {
                        for (int j = 2; j < numbers[i]; j++)
                        {

                            if (numbers[i] % j == 0)
                            {
                                count++;
                                break;
                            }
                            else
                            {
                                count += 0;
                            }
                        }
                    }



                    if (count == 0)
                    {
                        primeNumbers.Add(numbers[i]);
                    }
                    else
                    {
                        nonPrimeNumbers.Add(numbers[i]);
                        count = 0;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("the input type is not in correct type");
                
            }
         
            int p = 0, n = 0;

            for(int i=0;i<primeNumbers.Count;i++)
            {
                p +=(int)primeNumbers[i];
            }
            for(int i=0;i< nonPrimeNumbers.Count;i++)
            {
                n += (int)nonPrimeNumbers[i];
            }

            Console.WriteLine("sum of prime numbers:"+p);
            Console.WriteLine("sum of non-prime numbers:"+n);

            primeNumbers.Sort();
            Console.Write("PRIME NUMBERS:");
            foreach (int item in primeNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            nonPrimeNumbers.Sort();
            Console.Write("NONPRIME NUMBERS:");
            foreach (int item in nonPrimeNumbers)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

        }
    
    }
}
