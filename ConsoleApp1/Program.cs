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
            Random lenght = new Random();
            Random value = new Random();

            // Создание массива.
            int[] array = new int[lenght.Next(50, 100)];

            // Заполнение массива.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value.Next(0, 2);
            }

            // Вывод на экран.

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0 && count != 0)
                {
                    if ((i - 1) >= count)  // игнорируем единицы в начале массива
                    {
                        Console.Write($"Нуль по индексу: ");
                        Console.Write($"{(i - 1) - count} = {count}\n");
                    }
                    count = 0;
                    continue;
                }
                else if (array[i] == 1)
                {
                    count++;
                    if (i == array.Length - 1)  // учитываем тот факт, когда массив закончивается с единицами
                    {
                        Console.Write($"Нуль по индексу: ");
                        Console.Write($"{i - count} = {count}\n");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
