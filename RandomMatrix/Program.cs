using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Введите количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write ("Введите количество столбцов: ");
            int column = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[,] arr = new int[line, column]; 

            for (int i = 0; i < line; i++) 
            {
                int sum = 0;

                for (int j = 0; j < column; j++)
                {
                    arr [i, j] = random.Next(0, 100);
                    sum += arr[i, j];
                    Console.Write ($" {arr [i, j] ,2} ");
                }
                Console.WriteLine($" : {sum}");
            }
            Console.ReadKey();
        }
    } 
}

