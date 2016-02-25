using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class MathExt
    {
        /// <summary>
        /// Проверка на треугольник
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns></returns>
        public static bool IsTringle(double a, double b, double c)
        {
            if (a + b > c && a + c > b&&c + b > a) return true;
            return false;
        }


        /// <summary>
        /// Проверка на треугольник
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns></returns>

        public static bool IsStraightTringle(double a, double b, double c)
        {
            if (a>b&&a>c)
            {
                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else if (b>a&&b>c)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else if(c>a&&c>b)
            {
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Вычисление плошади прямоугольного  труегольника треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <returns>Площадь</returns>

        public static double TringleArea(double a, double b, double c)
        {
            double rez = 0;
            if (a > b && a > c)
            {
                rez = (b * c) / 2;
            }
            else if (b > a && b > c)
            {
                rez = (a * c) / 2;
            }
            else if (c > a && c > b)
            {
                rez = (a * b ) / 2;
            }
            return rez;
        }
    }
}
