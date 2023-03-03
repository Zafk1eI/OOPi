using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personal personal = new Personal() { LastName = "Pupkin", FirstName = "Vasya", age = 14, Position = "junior" };
            Bomsh bomsh = new Bomsh() { LastName = "Безпечени", FirstName = "Петя", age = 65, Residence = "Улица" };
            Console.WriteLine("Человек без определенного места жительства:");
            bomsh.Write();
            bomsh.writeResidence();
            Console.WriteLine("\nРаботник комании: ");
            personal.Write();
            Console.ReadKey();
        }
    }
}
