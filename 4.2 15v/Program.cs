using System;

namespace _4._2_15v
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.2 средний уровень
            Console.WriteLine("Введите размер массива n:");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n,n]; ;
            int summ = 0;
            Random random = new Random();
            int rows = mas.GetUpperBound(0) + 1;    
            int columns = mas.Length / rows;        
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    mas[x, y] = random.Next(50); 
                }
          
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            for (int j= 0; j < n; j++)
                summ += mas[j, n - 1];
            Console.WriteLine("Суммa элементов последнего столбца = " + summ);

        }
    }
}
