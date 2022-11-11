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
            int m, n, c;
            while (true)
            {
                Console.Write("Столбцов: ");
                if (int.TryParse(Console.ReadLine(), out m))
                {
                    Console.Write("Строк: ");
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                        int[,] mas = new int[m, n];
                        Console.WriteLine();
                        Console.WriteLine("Заполни матрицу");
                       
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write("mas[" + i + "," + j + "]: ");
                                if (int.TryParse(Console.ReadLine(), out c))
                                {
                                    mas[i, j] = c;
                                }
                                
                                else
                                {
                                    Console.WriteLine("Ты втираешь мне каку-то дичь!");
                                }

                            }

                        }
                        Console.WriteLine();

                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine(f(mas));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Введите цифры!");
                    }
                }
                else
                {
                    Console.WriteLine("Введите цифры!");
                }

            }

            
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
                Console.Write("\nСума в строке " + i + " = " + accumulator + ' ');
            }
            return res;
        }
    }
}