using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEntier
{
    internal class TPEntier
    {
        public TPEntier()
        {
           
            Int64 integer = Convert.ToInt64(Console.ReadLine());
         
            Console.WriteLine(4 * integer);
            Console.ReadLine();

           // int entier = 1000000000;
            //Console.WriteLine(5 * entier);
           // Console.ReadLine();
        }

        static void Main(string[] args)
        {
            new TPEntier();
        }
    }
}
