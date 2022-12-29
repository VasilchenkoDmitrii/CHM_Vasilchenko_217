using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CHM
{
    delegate double func(double arg);
    public partial class Form1 : Form
    {
        Pen _axisPen;
        Pen _graphPen;
        Point _Opoint;
        double _XMin, _XMax;
        double _YMin, _YMax;
        int step;
        CoorTextBox[] _coorTextBoxes;

        List<DPoint> _points;
        LangrangePolynom _polynom;
        CubicSpline _spline;

        public Form1()
        {
            InitializeComponent();
            _Opoint = new Point(225, 225);
            _XMin = 0;
            _XMax = 1;
            _YMin = 0;
            _YMax = 1;
            _axisPen = new Pen(Color.Black, 2);
            _graphPen = new Pen(Color.Black, 1);
            _coorTextBoxes = new CoorTextBox[4] {_CTextBoxXMin, _CTextBoxXMax, _CTextBoxYMin, _CTextBoxYMax };
            step = 2;
            _points = new List<DPoint>();
            _polynom = new LangrangePolynom();
            _spline = new CubicSpline();
            NetRichTextBox.Text = @"0 0
0.2 1.027775
0.4 1.356512
0.6 0.257137
0.8 1.684295
1 2.606626
1.2 0.9727692
1.4 2.664212
1.6 4.900323
1.8 2.493172
2 4.019803";
            this._CTextBoxYMin.Text = "0";
            this._CTextBoxXMin.Text = "0";
            this._CTextBoxYMax.Text = "1";
            this._CTextBoxXMax.Text = "1";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        void update()
        {
            getPoints(_points);
            _polynom.clear();
            updatePolynom();
            updateSpline();
            _plot.Invalidate();
            SplineRichTextBox.Text = _spline.ToString();
            PolynomRichTextBox.Text = _polynom.ToString();
        }
        void readPointsFromString(List<DPoint> points)
        {
            points.Clear();
            string values = @"0 0
0.2 1.027775
0.4 1.356512
0.6 0.257137
0.8 1.684295
1 2.606626
1.2 0.9727692
1.4 2.664212
1.6 4.900323
1.8 2.493172
2 4.019803";
            string values1 = @"0 0
0.52 0.5
1.04 0.86
1.52 1";
          /*  string values = @"0 0 
0.1 0.529847
0.2 1.027775 
0.3 1.346477
0.4 1.356512 
0.5 0.986714
0.6 0.257137 
0.7 0.706391
0.8 1.684295 
0.9 2.404336
1 2.606626 
1.1 2.11956
1.2 0.927692 
1.3 0.789339
1.4 2.664212 
1.5 4.203824
1.6 4.900323 
1.7 4.370876
1.8 2.493172 
1.9 0.502452
2 4.019803";*/
            string[] lines = NetRichTextBox.Text.Split('\n');
            for (int i = 0; i < lines.Length; ++i)
            {
                string s = lines[i];
                string[] strs = s.Split(' ');
                DPoint p = new DPoint(Convert.ToDouble(strs[0]), Convert.ToDouble(strs[1]));
                points.Add(p);
            }
        }
        void getPoints(List<DPoint> pts)
        {
            readPointsFromString(pts);
        }
        void updatePolynom()
        {
            _polynom.fillValues(_points);
        }
        void updateSpline()
        {
            _spline.fillValues(_points);
        }
        void updateCornerPoints()
        {
            _XMin = _coorTextBoxes[0].coordinate;
            _YMin = _coorTextBoxes[2].coordinate;
            _XMax = _coorTextBoxes[1].coordinate;
            _YMax = _coorTextBoxes[3].coordinate;
        }

        double SplineFunc(double x)
        {
            return _spline.calculate(x);
        }
        double PolynomFunc(double x)
        {
            return _polynom.calculate(x);
        }





        int mapping(int value, int pixelsCount, int current)
        {
            double tmp = (double)current / (double)pixelsCount;
            return (int)(value * tmp);
        }
        void FromNormalToWF(ref int x, ref int y, Size plotSize)
        {
            y = plotSize.Height - y;
        }
        Point FromNormalToWF(Point p, Size plotSize)
        {
            return new Point(p.X, plotSize.Height -  p.Y);
        }
        private void drawAxe(Graphics graphics)
        {
            Point p1, p2;
            int tmp = 0;
            if(_XMin <= 0 && _XMax > 0)
            {
                tmp = (int)(650 * (-_XMin) / (_XMax - _XMin));
                p1 = new Point(tmp, 0);
                p2 = new Point(tmp, 650);
                graphics.DrawLine(_axisPen, FromNormalToWF(p1, _plot.Size), FromNormalToWF(p2, _plot.Size));
            }
            if(_YMin <= 0 && _YMax > 0)
            {
                tmp = (int)(650 * (-_YMin) / (_YMax - _YMin));
                p1 = new Point(0, tmp);
                p2 = new Point(650, tmp);
                graphics.DrawLine(_axisPen, FromNormalToWF(p1, _plot.Size), FromNormalToWF(p2, _plot.Size));
            }
        }
        private void drawNet(Graphics graphics)
        {

            for(int i = 0; i < 50; ++i)
            {
                graphics.DrawLine(new Pen(Color.LightGray), 0, i * (float)13, 650, i * (float)13);
                graphics.DrawLine(new Pen(Color.LightGray), i * (float)13, 0, i * (float)13, 650);
            }
        }
        private void drawPoints(Graphics graphics, List<DPoint> points)
        {
            int x, y;
            double lx = _XMax - _XMin;
            double ly = _YMax - _YMin;
            if (lx == 0 || ly == 0) return;
            foreach (DPoint point in points)
            {
                x = (int)((point.X - _XMin) *650 / lx);
                y = (int)((point.Y - _YMin) * 650 / ly);
                graphics.FillEllipse(Brushes.Red, x-3, 650 - y-3, 6, 6);
            }
        }
        private void drawFunc(Graphics graphics, func function, Pen pen)
        {
            double lx = _XMax - _XMin;
            double ly = _YMax - _YMin;
            if(lx == 0 || ly == 0) return;
            double x1, y1, x2, y2;
            x1 = 0;
            y1 = ((function(_XMin) - _YMin) * 650 / ly);
            for(int i = 1; i < 650; i+= step)
            {
                x2 = i;
                y2 = ((function(_XMin + i * lx / 650) - _YMin) * 650 / ly);
                if (y2 >= 650) y2 = 650;
                if (y2 <= 0) y2 = 0;
                 graphics.DrawLine(pen, (float)x1, 650 - (float)y1, (float)x2, 650 - (float)y2);
                x1 = x2;
                y1 = y2;
            }
        }


        private void _buttonReDraw_Click(object sender, EventArgs e)
        {
            updateCornerPoints();
            update();
        }

      

        private void _plot_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.Clear(_plot.BackColor);
            drawNet(e.Graphics);
            drawAxe(e.Graphics);
            if(PointsCheckBox.Checked)drawPoints(e.Graphics, _points);
            if(SplineCheckBox.Checked)drawFunc(e.Graphics, SplineFunc, new Pen(Color.Blue, 2));
            if(LagrangeCheckBox.Checked)drawFunc(e.Graphics, PolynomFunc, new Pen(Color.Green, 2));
        }
        private void CoorTextBox_textChanged(object sender, EventArgs e)
        {
            try
            {
                ((CoorTextBox)sender).coordinate = Convert.ToDouble(((CoorTextBox)sender).Text);
                updateCornerPoints();
            }
            catch
            {
                ((CoorTextBox)sender).Text = "0";
            }
        }
    }
}
