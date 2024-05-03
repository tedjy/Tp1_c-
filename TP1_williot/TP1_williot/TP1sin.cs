using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_williot
{
    internal class TP1sin
    {
        public TP1sin()
        {
            string val = Console.ReadLine();
            double valeurConvertie = Convert.ToDouble(val);
            Console.WriteLine(Math.Sin(valeurConvertie));
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            new TP1sin();
        }
    }
}
