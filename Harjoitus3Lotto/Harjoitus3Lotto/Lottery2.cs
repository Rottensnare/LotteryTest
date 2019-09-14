using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3Lotto
{
    class Lottery2
    {
        public static void Arvonta2()
        {
            int n;
            int[] numerot = new int[7];
            Random rand = new Random();
            for (int i = 0; i < numerot.Length; i++)
            {
                do
                {
                    n = rand.Next(1, 36);
                }
                while (numerot.Contains(n));

                numerot[i] = n;
            }
            Array.Sort(numerot);
            for(int x = 0; x<numerot.Length; x++)
            {
                Console.WriteLine(numerot[x]);
            }
            Console.WriteLine();
        }
    }
    
}
