using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Basis
{
    internal class Sort
    {
        public int[] BubbleSort(int[] mas)
        {
            int swapper = 0;
            for (var i = 1; i < mas.Length; i++)
            {
                for (var j = 0; j < mas.Length - i; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        swapper = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = swapper;
                    }
                }
            }
            return mas;
        }
    }
}
