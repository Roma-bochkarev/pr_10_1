using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace контрольная10._1
{
    class Program
    {
        static void Main (string[] args)
        {
            //exercise 15
            //int n, m;
            //try
            //{
            //    Console.WriteLine("введите число строк");
            //    n = int.Parse(Console.ReadLine());
            //    Console.WriteLine("введите число столбцов");
            //    m = int.Parse(Console.ReadLine());
            //    int[,] arr = new int[n, m];
            //    arr = Ex1(arr);
            //    Ex2(arr);
            //}
            //catch
            //{
            //    Console.WriteLine("Упс, что-то пошло не так");
            //}
            //Console.ReadKey();

            //exercise 18
            int n, m;
            try
            {
                Console.WriteLine("введите число строк");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("введите число столбцов");
                m = int.Parse(Console.ReadLine());
                int[,] arr = new int[n, m];
                arr = Ex1(arr);
                Ex3(arr);
                Ex4(arr);
            }
            catch
            {
                Console.WriteLine("Упс, что-то пошло не так");
            }
            Console.ReadKey();
        }

        static int[,] Ex1(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-10, 10);
                    Console.Write($"{arr[i, j], 4}");
                }
                Console.WriteLine(" ");
            }
            return arr;
        }

        static void Ex2(int[,] arr)
        {
            int sum = 0, k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < 0)
                    {
                        sum = sum + arr[i, j];
                        k++;
                    }

                }
                Console.WriteLine($"сумма {i} ряда: {sum}, среднее врифметическое: {sum / k}");
                sum = 0;
                k = 0;
            }
        }

        static void Ex3 (int[,] arr)
        {
            Console.WriteLine("введите делитель");
            int k = int.Parse(Console.ReadLine());
            int d = 0, sum = 0;
            Console.WriteLine("введите 1 позицию");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите 2 позицию");
            int s2 = int.Parse(Console.ReadLine());
            try
            {
                if (s2 > s1 && s2 < arr.GetLength(1))
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] >= 0)
                            {
                                if (arr[i, j] % k == 0)
                                {
                                    d++;
                                }
                            }
                            if (j >= s1 && j <= s2)
                                sum = sum + arr[i, j];
                        }
                        Console.WriteLine($"количество положительных, кратных {k} в {i + 1} строке равно {d}, сумма с s1 до s2 равна {sum}");
                        d = 0;
                        sum = 0;
                    }
                }
                else
                    Console.WriteLine("позиции не верны");
            }
            catch
            {
                Console.WriteLine("Упс, кажется что-то пошло не так :(");
            }
        }
        static void Ex4 (int[,] arr)
        {
            Console.WriteLine("введите делитель 1");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите делитель 2");
            int k2 = int.Parse(Console.ReadLine());
            int d = 0, pr = 1;
            try
            {
                
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                           if (arr[i, j] < 0)
                           {
                               pr = pr * arr[i, j];
                           }
                           if (arr[i, j] % k1 == 0 || arr[i,j] % k2 == 0)
                           {
                               d++;
                           }
                            
                        }
                        Console.WriteLine($"количество положительных, кратных {k1} или {k2} в {i + 1} строке равно {d}, произведение отрицательных {pr}");
                        d = 0;
                        pr = 1;
                    }

            }
            catch
            {
                Console.WriteLine("Упс, кажется что-то пошло не так :(");
            }
        }
    }
}
