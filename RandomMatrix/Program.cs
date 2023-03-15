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

            int[,] arr = new int[line, column]; 

            int sum = 0;

            Random random = new Random();

            for (int i = 0; i < line; i++) 
            {
                for (int j = 0; j < column; j++)
                {
                   arr [i, j] = random.Next(0, 100);
                   Console.Write("{0}\t", arr [i, j]);   
                   sum += arr[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    } 
}

