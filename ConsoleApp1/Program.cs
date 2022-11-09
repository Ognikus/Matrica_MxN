using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Столбцов: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Строк: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[m, n];
            Console.WriteLine();

            Console.WriteLine("Заполни матрицу");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" mas[" + i + "," + j + "]: " + mas[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(f(mas));
            Console.ReadLine();
        }



        static String f(int[,] m)
        {
            String res = "";
            int rows = m.GetUpperBound(0) + 1;    // количество строк
            int columns = m.GetUpperBound(1) + 1;        // количество столбцов

            for (int i = 0; i < rows; i++)
            {
                int accumulator = 0;
                for (int j = 0; j < columns; j++)
                {
                    accumulator += m[i, j];
                }
                Console.Write("Сума в строке " + i + " = " + accumulator + ' ');
            }
            return res;
        }
    }
}