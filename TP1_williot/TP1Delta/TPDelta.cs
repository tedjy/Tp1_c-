using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Delta
{
    internal class TPDelta
    {

        public TPDelta()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double deltaForm = b * b - 4 * a * c;
           
           

            if (deltaForm > 0)
            {
                double x1 = -b + Math.Sqrt(deltaForm) / 2 * a;
                double x2 = -b - Math.Sqrt(deltaForm) / 2 * a;
                Console.WriteLine("deux solution");
                Console.WriteLine(x1);
                Console.WriteLine(x2);
                Console.ReadLine();
            } 
            else if (deltaForm == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("une solution");
                Console.WriteLine(x);
                Console.ReadLine();
            } 
            else if (deltaForm < 0)
            {
                Console.WriteLine("pas de solution");
                Console.ReadLine();
            }
 
            Console.WriteLine(deltaForm);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            new TPDelta();
        }
    }
}
