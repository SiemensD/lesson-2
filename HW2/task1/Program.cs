using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 0, 2, 0, 3, 0, 4, 0, 5, 6,0,0,7,8,9 };
           
            int[] array2 = new int[array1.Length];

            for (int i = 0, j=0; i < array1.Length; i++)
            {
                
                if (array1[i]!=0)
                {
                    
                    array2[j] = array1[i];
                    j++;
                }               
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == 0)
                    array2[i] = -1;
            }

            Console.WriteLine("Массив до копирования");
            foreach (var i in array1)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Массив после копирования и замены нулей на -1");
            foreach (var i in array2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
/*1. Сжать массив, удалив из него все 0 и, 
 * заполнить освободившиеся справа элементы 
 * значениями –1*/