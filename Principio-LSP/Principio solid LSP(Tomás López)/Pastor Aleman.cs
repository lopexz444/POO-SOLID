using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_solid_LSP_Tomás_López_
{
    public class PastorAleman : Perro
    {
        public override void Comer()
        {
            Console.WriteLine("El pastor alemán está comiendo su buenas croquetas.");
        }
        public void Ladrar()
        {
            Console.WriteLine("El Pastor aleman ladra: goff gua goof.");
        }
    }
}
