using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_solid_LSP_Tomás_López_
{
    public class PerroMudo : Perro
    {
        public override void Comer()
        {
            Console.WriteLine("El perro mudo puede comer croquetas.");
        }
    }
}
