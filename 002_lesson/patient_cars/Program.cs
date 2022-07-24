using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patient_card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double patientWeight;
                int patientAge;
                bool patientSex;

                Console.Write("Введите имя:  ");
                string patientFirstName = Console.ReadLine();

                Console.Write("Введите фимилию:  ");
                string patientLastName = Console.ReadLine();

                Console.Write("Введите возраст:  ");
                patientAge = Convert.ToInt16(Console.ReadLine());

                Console.Write("Введите вес:  ");
                patientWeight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите пол: 1 для мужчины, 0 для женщины:  ");
                if (Console.ReadLine() == "1")
                {
                    patientSex = true;
                }
                else
                {
                    patientSex = false;
                }
                Console.WriteLine("---------------");
                Console.WriteLine($"Имя пациента    :  {patientFirstName}");
                Console.WriteLine($"Фамилия пациента:  {patientLastName}");
                Console.WriteLine($"Возраст пациента:  {patientAge}");
                Console.WriteLine($"Вес пациента    :  {patientWeight}");
                if (patientSex == true)
                {
                    Console.WriteLine($"Пол пациента    :  Мужской");
                }
                else
                {
                    Console.WriteLine($"Пол пациента    :  Женский");
                }
                Console.WriteLine("---------------");
                Console.ReadKey();
            }

        }
    }
}
