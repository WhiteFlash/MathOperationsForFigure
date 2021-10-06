using Figures.Lib.Interfaces;
using System;

namespace Figures.Lib
{
    public class Circle : ISquareFigure
    {
        private int _radius;

        public Circle(int _r)
        {
            _radius = _r;
        }
        public double Square { get; set; }
        public double Radius { get; set;  }
        public void CountSquare()
        {
            double square = Math.PI * Math.Pow(_radius, 2);
            double squareWithoutExtraDigits = Math.Round(square, 2);
            Square = squareWithoutExtraDigits;

            // Тесты не проходили, если вот так написать.
            // Square = (double)Math.Round((float)(Math.PI * Math.Pow(_radius, 2)), 2);
        }
    }
}
