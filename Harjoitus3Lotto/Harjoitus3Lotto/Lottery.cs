using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3Lotto
{
    class Lottery
    {
        public static void Arvonta()
        {

            int[] numbers = new int[7];
            Random rnd = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 8);
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers[i] = rnd.Next(1, 8);
                        j = -1;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(numbers[i]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(numbers[i]);
            }
            //for (int k = 1; k < numbers.Length; k++)
            //{
            //    if (numbers[0] == numbers[k])
            //    {
            //        Arvonta();
            //    }
                
            //}
           
          
           Console.Clear();
            //int[] copyArray = numbers.ToArray();
            //int[] sortedCopy = numbers.OrderBy(i => i).ToArray();
            Array.Sort(numbers);
            for (int x = 0; x < numbers.Length; x++)
            {

                Console.WriteLine(numbers[x]);
            }

            Console.WriteLine();


        }


    }
}
