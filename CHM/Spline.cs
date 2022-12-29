using System;
using System.Collections.Generic;
using System.Text;

namespace CHM
{
    class Spline // Сплайн на конкретной части сетки
    {
        public double A, B, C, D;
        public double X;
        public Spline()
        {

        }
        public double calculate(double x)
        {
            return D * x * x * x / 6.0 + C * x * x / 2.0 + B * x + A;
        }
        public override string ToString()
        {
            string res = "";
            res += $"{X}:---> {D / 6.0} * (x - {X})^3 + {C / 2.0} * (x - {X})^2 + {B} * (x - {X}) + {A}";
            return res;
        }
    }
}
