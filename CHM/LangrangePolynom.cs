using System;
using System.Collections.Generic;
using System.Text;

namespace CHM
{
    internal class LangrangePolynom
    {
        List<QPolynom> _Qpolynoms;
        List<double> _Coefficients;
        public LangrangePolynom()
        {
            _Qpolynoms = new List<QPolynom>();
            _Coefficients = new List<double>();
        }
        public void fillValues(List<DPoint> points)
        {
            for(int i = 0; i < points.Count; ++i)
            {
                QPolynom pol = new QPolynom();
                pol.fillValues(points, i);
                _Qpolynoms.Add(pol);
                _Coefficients.Add(points[i].Y);
            }
        }
        public double calculate(double x)
        {
            double res = 0;
            for(int i = 0;i < _Qpolynoms.Count; ++i)
            {
                res += _Coefficients[i] * _Qpolynoms[i].calculate(x);
            }
            return res;
        }
        public void clear()
        {
            _Qpolynoms.Clear();
            _Coefficients.Clear();
        }
        public override string ToString()
        {
            string res = "";
            for(int i = 0; i < _Coefficients.Count; ++i)
            {
                res += _Coefficients[i].ToString() + "*(" + _Qpolynoms[i].ToString() + ")";
                if (i != _Coefficients.Count - 1) res += " + ";
            }
            return res;
        }
    }
}
