using Figures.Lib.AbstractClass;
using System;

namespace Figures.Lib
{
    public class Circle : ASquare
    {
        private readonly int radius;

        public Circle(int _r)
        {
            radius = _r;
            CountSquare();
        }
        public override double Square { get; set; }

        public override void CountSquare()
        {
            double square = Math.PI * Math.Pow(radius, 2);
            double squareWithoutExtraDigits = Math.Round(square, 2);
            Square = squareWithoutExtraDigits;

            // Тесты не проходили, если вот так написать.
            // Square = (double)Math.Round((float)(Math.PI * Math.Pow(radius, 2)), 2);
        }
    }
}
