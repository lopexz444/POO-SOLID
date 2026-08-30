using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_Solid_ISP_Toás_López_
{
    public class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El robot está trabajando.");
        }
    }
}
