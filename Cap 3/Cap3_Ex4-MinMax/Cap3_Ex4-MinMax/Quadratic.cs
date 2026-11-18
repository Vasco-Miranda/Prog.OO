using System;
using System.Collections.Generic;
using System.Text;

namespace Cap3_Ex4_MinMax
{
    internal class Quadratic
    {
        double a;
        double b;
        double c;

        bool neg;

        private double Descriminant()
        {
            double delta = b * b - (4 * a * c);
            if (delta < 0)
            {
                neg = true;
                delta = -delta;
            }

            return delta;
        }

        public string Roots(double a, double b, double c)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;

            double delta = Descriminant();

            if (neg)
            {
                return "";
            }
            else
            {
                double pos = (-b + Math.Sqrt(delta)) / 2.0 * a;
                double neg = (-b - Math.Sqrt(delta)) / 2.0 * a;

                pos = Double.Round(pos, 3);
                neg = Double.Round(neg, 3);

                string res = pos.ToString() + "," + neg.ToString();
                return res;
            }
        }
    }
}
