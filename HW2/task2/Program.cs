using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, -3, 12, -15, 3, -4, 0, 4, -32, 5, 6, -7, -45, 7, 8, 9 };
            Console.WriteLine("Массив до копирования");
            foreach (var i in array1)
            {
                Console.Write(i+" ");
            }

            Array.Sort(array1);

            Console.WriteLine("\n\nМассив после преобразования");
            foreach (var i in array1)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine();
        }
    }
}
/*2. Преобразовать массив так, чтобы сначала шли все
отрицательные элементы, а потом положительные
(0 считать положительным)*/