using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojenieMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int column = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[,] arr1 = new int[line, column];
            int[,] arr2 = new int[line, column];
            int[,] arr3 = new int[line, column];


            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr1[i, j] = random.Next(0, 100);
                    Console.Write($" {arr1[i, j],2} ");
                }
            }

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr2[i, j] = random.Next(0, 100);
                    Console.Write($" {arr2[i, j],2} ");
                }
            }

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                    Console.Write($" {arr3[i, j],2} ");
                }
            } Console.ReadLine();
        } 
    }
}
