using System;
using System.Collections.Generic;
using System.Text;

namespace CHM
{
    internal class DPoint
    {
        private double _x;
        private double _y;
        public DPoint()
        {
            _x = 0;
            _y = 0;
        }
        public DPoint(double x, double y){
            _x = x;
            _y = y;
        }
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
