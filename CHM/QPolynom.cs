using System;
using System.Collections.Generic;
using System.Text;

namespace CHM
{
    internal class QPolynom
    {
        List<LinearScope> _denominator;
        List<LinearScope> _numerator;
        public QPolynom()
        {
            _denominator = new List<LinearScope>();
            _numerator = new List<LinearScope>();
        }
        
        public void fillValues(List<DPoint> points, int ignorIndex)
        {
            for(int i = 0; i < points.Count; ++i)
            {
                if (i == ignorIndex) continue;
                _numerator.Add(new LinearScope(points[i].X));
            }
            for(int i = 0; i < points.Count; ++i)
            {
                if (i == ignorIndex) continue;
                _denominator.Add(new LinearScope(points[ignorIndex].X, points[i].X));
            }
        }
        public double calculate(double x)
        {
            double den = 1;
            double num = 1;
            foreach(LinearScope val in _numerator)
            {
                num *= val.calculate(x);
            }
            foreach(LinearScope val in _denominator)
            {
                den *= val.calculate(x);
            }
            return num / den;
        }
        public override string ToString()
        {
            string res = "";
            for(int i = 0;i < _numerator.Count; ++i)
            {
                res += _numerator[i].ToString();
                if (i != _numerator.Count - 1) res += " * ";
            }
            res += " / ";
            for (int i = 0; i < _denominator.Count; ++i)
            {
                res += _denominator[i].ToString();
                if (i != _denominator.Count - 1) res += " * ";
            }
            return res;
        }
    }
}
