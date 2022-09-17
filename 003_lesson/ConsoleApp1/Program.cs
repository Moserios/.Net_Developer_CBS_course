using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Zadanie 1");

                int x = 10;
                int y = 12;
                int z = 3;

                double result1 = (x += (y - x++ * z));
                Console.WriteLine(result1);

                double result2 = (z = --x - y * 5);
                Console.WriteLine(result2);

                double result3 = (y /= x + 5 % z);
                Console.WriteLine(result3);

                double result4 = (z = x++ + y * 5);
                Console.WriteLine(result4);

                double result5 = (x = y - x++ * z);
                Console.WriteLine(result5);
                Console.WriteLine();
            }

            {
                Console.WriteLine("Zadanie 2");
                double x = 10;
                double y = 12;
                double z = 3;

                double r = (x + y + z) / 3;
             
                Console.WriteLine("Среднее арифметические для {0}, {1}, {2} = {3}", x, y, z, r);
                Console.WriteLine();
            }

            {
                Console.WriteLine("Zadanie 3");
                const double pi = 3.14159;
                double r = 12;
               
                double result = pi * Math.Pow(r, 2);

                Console.WriteLine("Площадь круга для радиуса {0} = {1}", r, result);
                Console.WriteLine();
            }
            {
                Console.WriteLine("Zadanie 4");
                const double pi = 3.14159;
                double h = 12;
                double r = 4;

                double s = 2 * pi * r * (r + h); /* вычисляем площадь поверхности цилиндра*/
                double v = pi * Math.Pow(r, 2) * h; /* вычисляем объем цилиндра*/

                Console.WriteLine("Площадь поверхности цилиндра с высотой {0} и радиусом {1} = {2}", h, r, s);
                Console.WriteLine("Объем цилиндра с высотой {0} и радиусом {1} = {2}", h, r, v);
                Console.WriteLine();
            }

            {
                Console.WriteLine("Zadanie 5");
                //int uberflu? = 1;
                int _Identifier = 2;
                int \u006fIdentifier = 3;
                //int &myVar = 4;
                int myVariab1le = 5;

                Console.WriteLine("uberflu?" + " " + _Identifier + " " + " " + \u006fIdentifier + " " + "&myVar" + " " + myVariab1le);
                Console.WriteLine();

            }

            {
                Console.WriteLine("Zadanie 7");
                
                int x = 4;
                int y = 5;
                int result1 = x + y; /* сложение */
                int result2 = x * y; /* умножение */
                int result3 = x - y; /* вычитание */
                double result4 = x / y; /* деление без остатка */
                double result5 = x % y; /* остаток от деления */
                double result6 = Math.Pow(x, y); /* возведение в степень */
                double result7 = Math.Sqrt(y); /* извлечение квадратного корня */


                Console.WriteLine("Сложение {0} + {1} = {2}", x, y, result1);
                Console.WriteLine("Умножение {0} * {1} = {2}", x, y, result2);
                Console.WriteLine("Вычитание {0} - {1} = {2}", x, y, result3);
                Console.WriteLine("Деление без остатка {0} / {1} = {2}", x, y, result4);
                Console.WriteLine("Остаток от деления {0} % {1} = {2}", x, y, result5);
                Console.WriteLine("Возведение в степень: {0} в степени {1} = {2}", x, y, result6);
                Console.WriteLine("Извлечение квадратного корня из {0} = {1}", y, result7);

                Console.WriteLine();
            }



            Console.ReadKey();

        }

    }
}
