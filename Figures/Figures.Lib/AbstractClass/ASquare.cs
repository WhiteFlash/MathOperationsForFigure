using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Lib.AbstractClass
{
    public abstract class ASquare
    {
        public ASquare()
        {
            CountSquare();
        }

        public abstract double Square { get; set; }
        public abstract void CountSquare();
    }
}
