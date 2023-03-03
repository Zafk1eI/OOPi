using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            Random rand = new Random();
            Sort bubble = new Sort();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(20);
                Console.WriteLine("Значение элемента массива " + i + " = " + mas[i]);
            }
            bubble.BubbleSort(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine("отсортированные Значения элемента массива " + i + " = " + mas[i]);
            }
            Console.ReadKey();
        }
    }
}
