using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_Solid_ISP_Toás_López_
{
    public class Humano : ITrabajador, IEat
    {
        public void Comer()
        {
            Console.WriteLine("El humano está comiendo.");
        }
        public void Trabajar()
        {
            Console.WriteLine("El humano está trabajando.");
        }
    }
}
