using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PiNumber = 3.141592653;
            const decimal ElNumber = 2.7182818284590452M;
            string a = "\nмоя строка 1";
            string b = "\nмоя строка 2";
            string c = "\nмоя строка 3";


            Console.WriteLine(PiNumber);
            Console.WriteLine(ElNumber);
            Console.WriteLine("__________");

            Console.WriteLine(a);
            Console.WriteLine(b);  
            Console.WriteLine(c);


            Console.ReadKey();  
        }
    }
}
