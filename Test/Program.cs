using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = false;
            double a=0, b=0, c=0,rez;
            while (!ok)
            {
                Console.WriteLine("Введите стороно A");
               ok= Double.TryParse(Console.ReadLine().Replace(".",","), out a);
               if (!ok) Console.WriteLine("Это не число!");

            }
            ok = false;
            while (!ok)
            {
                Console.WriteLine("Введите стороно B");
                ok = Double.TryParse(Console.ReadLine().Replace(".", ","), out b);
                if(!ok)Console.WriteLine("Это не число!");
            }
            ok = false;
            while (!ok)
            {
                Console.WriteLine("Введите стороно C");
                ok = Double.TryParse(Console.ReadLine().Replace(".", ","), out c);
                if (!ok) Console.WriteLine("Это не число!");
                
            }
            if (MathExt.IsTringle(a, b, c))
            {
                if (MathExt.IsStraightTringle(a, b, c))
                {
                    rez = MathExt.TringleArea(a, b, c);
                }
                else
                {
                    Console.WriteLine("Это не прямоугольный треугольник!");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Это не треугольник!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(string.Format("Площадь треугольника = {0}.",rez));
            Console.ReadKey();


        }
    }
}
