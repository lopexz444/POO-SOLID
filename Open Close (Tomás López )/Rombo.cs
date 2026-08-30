using DemoOpenClosePrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Close__Tomás_López__
{
    public class Rombo : Shape
    {
        public double DiagonalMayor { get; set; }
        public double DiagonalMenor { get; set; }

        public override double Area() => (this.DiagonalMayor * this.DiagonalMenor) / 2;
    }
}
