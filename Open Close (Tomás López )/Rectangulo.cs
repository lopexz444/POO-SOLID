using DemoOpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Close__Tomás_López__
{
    public class Rectangulo : Shape
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double Area() => (this.Base * this.Altura);
    }
}
