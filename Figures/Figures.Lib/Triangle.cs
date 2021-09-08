using Figures.Lib.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Lib
{
    public class Triangle : ASquare
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get => this.a;
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Value for the side can not be 0 or less. Your value {value}");
                }
                this.a = value;
            }
        }
        public int B
        {
            get => this.b;
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Value for the side can not be 0 or less. Your value {value}");
                }
                this.b = value;
            }
        }
        public int C
        {
            get => this.c;
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Value for the side can not be 0 or less. Your value {value}");
                }
                this.c = value;
            }
        }

        public Triangle(int _a, int _b, int _c)
        {
            A = _a;
            B = _b;
            C = _c;
            CountSquare();
            CheckForRightAngled();
        }

        public override double Square { get; set; }
        public bool IsRightAngled { get; private set; }

        public override void CountSquare() 
        {
            var p = (A + B + C) / 2;
            var s = Math.Sqrt(p*(p - A) * (p - B) * (p - C));
            Square = Math.Round(s, 2);
        }

        private void CheckForRightAngled()
        {
            CheckNumber();

            int _a = Convert.ToInt32(Math.Pow(A, 2));
            int _b = Convert.ToInt32(Math.Pow(B, 2));
            int _c = Convert.ToInt32(Math.Pow(C, 2));

            this.IsRightAngled = _c == _a + _b;    
        }

        private void CheckNumber()
        {
            int[] matrix = { A,B,C };
            Array.Sort(matrix);
        }

    }
}
