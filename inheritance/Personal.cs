using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Personal
    {
        private string firstname;
        private string lastname;
        private int Age;
        private string position; // job title
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public void Write()
        {
            Console.WriteLine(FirstName + " " + LastName + '\n' + "Age: " + Age + '\n' + "Занимает должность: " + Position);
        }
    }
    internal class Bomsh : Personal // наслдование
    {
        private string residence;
        public string Residence
        {
            get { return residence; }
            set { residence = value; }
        }
            public void writeResidence()
        {
            Console.WriteLine("местожительство: " + residence);
        }
    }
}
