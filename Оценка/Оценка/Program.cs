using System;
using System.Linq;

namespace Оценка
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Хотите я посчитаю вашу среднию оценку?");
            Console.Write("Введите количество оценок:\t");
            int count = int.Parse(Console.ReadLine());
            int[] nombers = new int[count];
            for (int i =0;i < count; i++)
            {
                Console.Write("Введи {0} оценку:\t", i + 1);
                nombers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ваша средняя оценка: {0}", nombers.Average());
            Console.ReadKey(); 
        }
    }
}
