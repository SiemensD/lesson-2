using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количеятво строк: ");
            int high = int.Parse(Console.ReadLine());
            Console.Write("Введите количество колонок: ");
            int width= int.Parse(Console.ReadLine());
            int[,] array1=new int[high,width];
            Random rand = new Random();

            Console.WriteLine();

            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    array1[i, j] = rand.Next(10);
                }
            }

            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    Console.Write(array1[i, j] +"\t");
                }
                Console.WriteLine();
            }


            Console.Write("Введите какую колонку хотите поменять: ");
            int kolumn1 = int.Parse(Console.ReadLine());
            Console.Write("Введите с какой колонкой хотите поменять: ");
            int kolumn2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                int temp;
                temp = array1[i, kolumn1];
                array1[i, kolumn1] = array1[i, kolumn2];
                array1[i, kolumn2] = temp;
            }

            Console.WriteLine();
            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
/* 4. В двумерном массиве порядка M на N поменяйте
      местами заданные столбцы.*/