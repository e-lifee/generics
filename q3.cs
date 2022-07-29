
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
            Console.WriteLine("please enter a sentence:");
            string sentence = Console.ReadLine();
           // sentence=sentence.ToUpper();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((int)sentence[i] == 65 || (int)sentence[i] == 69|| (int)sentence[i] == 73|| (int)sentence[i] == 79|| (int)sentence[i] == 85|| (int)sentence[i] == 97 || (int)sentence[i] == 101 || (int)sentence[i] == 105||(int)sentence[i] == 111 || (int)sentence[i] == 117 )
                {
                    sb.Append(sentence[i]);
                }
            }
            
            Console.WriteLine(sb);

            String word=sb.ToString();

            char[] chars = word.ToCharArray();

            foreach(char item in chars)
            {
                Console.Write(item + " ");
            }
            
            
            Console.ReadLine();

            }
        
    }
}
