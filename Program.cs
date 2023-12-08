using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            int row = 5;
            int col = 5;
            int w = 0;
            int[,] table = new int[row, col];
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {            
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    w++;
                    table[i, j] = w;
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите номер строки");
            int roww = Convert.ToInt32(Console.ReadLine());
            for (int j = 0 ; j < row; j++)
            {
                Console.Write(table[roww,j] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер столбца");
            int coll = Convert.ToInt32(Console.ReadLine());
            for (int i = 0 ; i < col; i++)
            {
                Console.Write(table[i, coll] + "\t");
            }

        }

        private static void ex2()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            int[,] table = new int[row, col];
            Console.WriteLine("Первый массив");
            for (int i = 0; i < row; i++)
            {
                string[] values = lines[i].Split(';');
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = Convert.ToInt32(values[j]);
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
            string[] lines2 = File.ReadAllLines("text.txt");
            int row2 = lines2.Length;
            int col2 = lines2[0].Split(';').Length;
            double[,] table2 = new double[row2, col2];
            Console.WriteLine("Второй массив");
            for (int i = 0; i < row2; i++)
            {
                string[] values2 = lines2[i].Split(';');
                Console.WriteLine();
                for (int j = 0; j < col2; j++)
                {
                    table2[i, j] = Convert.ToDouble(values2[j]);
                    Console.Write(table2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            double[,] resultArr = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < col; j++)
                    {
                        resultArr[i, j] = table[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < col; j++)
                    {
                        resultArr[i, j] = table2[i, j];
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(resultArr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void ex1()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int row = lines.Length;
            int col = lines[0].Split(';').Length;
            int[,] table = new int[row, col];
            int[] mass = new int[5];
            for (int i = 0; i < row; i++)
            {
                int max = 0;
                int min = 0;
                int[] mass1 = new int[5];
                string[] values = lines[i].Split(';');
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = Convert.ToInt32(values[j]);
                    mass1[j] = table[i, j];
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
                max = mass1.Max();
                min = mass1.Min();
                mass[i] = max + min;
            }
            int maxRow = Array.IndexOf(mass, mass.Max());
            int sred = 0;
            for (int i = maxRow; i == maxRow; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sred = sred + table[i, j];
                }
            }
            Console.WriteLine(sred / 5);
        }
    }
}
