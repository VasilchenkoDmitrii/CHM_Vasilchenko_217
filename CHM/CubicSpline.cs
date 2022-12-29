using System;
using System.Collections.Generic;
using System.Text;

namespace CHM
{
    class CubicSpline
    {
        Spline[] splines;


        public CubicSpline()
        {
        }

        public void fillValues(List<DPoint> points) //рассмотрел только случай равномерной сетки
        {
            splines = new Spline[points.Count];
            for (int i = 0; i < points.Count; ++i)
            {
                splines[i] = new Spline();
                splines[i].X = points[i].X;
                splines[i].A = points[i].Y;
            }
            splines[0].C = 0;
            splines[points.Count - 1].C = 0;

            // Решение СЛАУ относительно коэффициентов сплайнов c[i] методом прогонки для трехдиагональных матриц

            double[] alpha = new double[points.Count - 1];// прогоночные коэффициенты
            double[] beta = new double[points.Count - 1]; // 
            alpha[0] = beta[0] = 0.0;
            double A, B, C, F;
            double h_i;
            double h_i1;
            for (int i = 1; i < points.Count - 1; ++i) //Прямой ход метода прогонки
            {
                h_i = points[i].X - points[i - 1].X;
                h_i1 = points[i + 1].X - points[i].X;

                A = h_i; // вычисление коэффициентов матрицы в i-ой строчке
                B = h_i1;
                C = 2.0 * (h_i + h_i1); 
                F = 6.0 * ((points[i + 1].Y - points[i].Y) / h_i1 - (points[i].Y - points[i - 1].Y) / h_i);

                alpha[i] = -B / (A * alpha[i - 1] + C); //сам метод прогонки
                beta[i] = (F - A * beta[i - 1]) / (A * alpha[i - 1] + C);
            }

            // Нахождение решения - обратный ход метода прогонки
            for (int i = points.Count - 2; i > 0; --i)
            {
                splines[i].C = alpha[i] * splines[i + 1].C + beta[i];
            }

            //находим значения коэффициенты B, D
            for (int i = points.Count - 1; i > 0; --i)
            {
                h_i = points[i].X - points[i - 1].X;
                splines[i].D = (splines[i].C - splines[i - 1].C) / h_i;
                splines[i].B = h_i * (2.0 * splines[i].C + splines[i - 1].C) / 6.0 + (points[i].Y - points[i - 1].Y) / h_i;
            }
        }
        public double calculate(double x)
        {
            int index = 0;

            if (x <= splines[0].X) index = 0; //Крайние значения
            else if (x >= splines[splines.Length - 1].X) index = splines.Length - 1;

            else//в противном случае ищем нужный сплайн
            {
                for (int i = 0; i < splines.Length - 1; ++i)
                {
                    if (x >= splines[i].X && x <= splines[i + 1].X)
                    {
                        index = i + 1;
                        break;
                    }
                }
            }
            //double dx = x - splines[index].X;
            return splines[index].calculate(x - splines[index].X); //вычисление
        }

        public override string ToString()
        {
            string res = "";
            foreach(Spline sp in splines)
            {
                res += sp.ToString() + "\n";
            }
            return res;
        }
    }
}
