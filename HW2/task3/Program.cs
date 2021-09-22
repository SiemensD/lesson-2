using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = new int[20];
            Random rand = new Random();
            for (int i = 0; i< 20; i++)
            {
                array1[i] = rand.Next(1, 10);
            }

            Console.WriteLine("\t <<Эта программа считае количество повторений чисела в массиве>>\n\n ");

            Console.WriteLine("Массив целых чисел\n");
            foreach (var i in array1)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n\nВыбирете число из массива выше, количество которого \nхотите узнать: ");
            int value = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i]==value)
                {
                    count++;
                }
            }


            Console.WriteLine($"Количество повторений чиста {value} равно: {count}\n\n");
        }
    }
}
/*3. Написать программу, которая предлагает 
 * пользователю ввести число и считает, 
 * cколько раз это число встречается в массиве.*/