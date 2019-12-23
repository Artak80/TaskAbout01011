using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAbout01011
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Random rnd = new Random();
            Random rend = new Random();
            
            int[] array = new int[rend.Next(50,100)];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                int x = rnd.Next(0,2);
                array[i] = x;
            }

            // Вывод на экран.
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write($"Нуль по индексу: {i} = ");
                }
                if (array[i] == 0 && count != 0)
                {
                    Console.Write($"{count}\n");
                    Console.Write($"Нуль по индексу: {i} = ");

                    count = 0;
                    continue;
                }
                else if (array[i] == 1)
                {
                    count++;
                }
            }
            Console.ReadKey();
        }
    }
}
