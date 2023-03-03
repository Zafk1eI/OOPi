using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bazooka bazooka = new Bazooka();
            bazooka.Shoot();
            Console.ReadKey();
        }
    }
}
