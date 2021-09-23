using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashirenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bag = new int[1];
            int[] superBag = new int[bag.Length+1];

            for (int i=0; i < bag.Length;i++)
            {
                superBag[i] = bag[i];
            }

            superBag[superBag.Length - 1] = 15;

            bag = superBag;

            for (int i=0 ; i < bag.Length ; i++)
            {
                Console.WriteLine(bag[i]);
            }
        }
    }
}
