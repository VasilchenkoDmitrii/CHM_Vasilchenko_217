using System;
using System.Collections.Generic;
using System.Text;

namespace CHM
{
    internal class LinearScope
    {
        double _x;
        double _x1;
        bool _fixed;
        public LinearScope()
        {
            _fixed = true;
            _x = 0;
            _x1 = 0;
        }
        public LinearScope(double x1)
        {
            _fixed = false;
            this._x1 = x1;
            _x = 0;
        }
        public LinearScope(double x, double x1)
        {
            _fixed = true;
            _x = x;
            _x1 = x1;
        }
        public double calculate(double x)
        {
            if (_fixed) x = _x;
            return x - _x1;
        }
        public override string ToString()
        {
            if (_fixed) return $"({_x} - {_x1})";
            else return $"(x - {_x1})";
        }
    }
}
