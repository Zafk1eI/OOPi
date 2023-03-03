using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incap
{
    internal class Bazooka
    {
        private bool isLoaded = false;
        private void Reload()
        {
            isLoaded = true;
            Console.WriteLine("Базука заряжена\n");
        }
        public void Shoot()
        {
            if (isLoaded == false)
            {
                Console.WriteLine("Базука не заряжена\n");
                Reload();
            }
            Console.WriteLine("Boom!!!\n");
            isLoaded = false;
        }
    }
}

