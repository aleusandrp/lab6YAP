using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achievement__Unlocked_Ya_Sel_Za_Labu
{
    class Kvadrad
    {
        public delegate void Change();
        public event Change ChangeK;
        private double _A;
        private double _B;
        private double _C;

        public Kvadrad() { }
        public Kvadrad(double _A, double _B, double _C)
        {
            A = _A;
            B = _B;
            C = _C;
        }

        public double A
        {
            get{ return _A; }
            set{ _A = value;
                if (ChangeK != null)
                    ChangeK();
            }
        }
        public double B
        {
            get { return _B; }
            set {
                _B = value;
                if (ChangeK != null)
                    ChangeK();
            }
        }
        public double C
        {
            get { return _C; }
            set { _C = value;
                if (ChangeK != null)
                    ChangeK();
            }
        }
        public double D
        {
            get { return Math.Pow(B, 2) - 4 * A * C; }
        }
        public virtual string Korni()
        {
            if (A == 0 && B == 0 && C == 0)
                return "Х ∈ ∞";
            else if (A == 0 && B == 0 || D < 0)
                return "Корней нет";
            else if (A == 0 && B != 0)
                return String.Format("{0:0.0}", (-C / B));
            else
            {
                double K1 = (-B + Math.Sqrt(D)) / (2 * A);
                double K2 = (-B - Math.Sqrt(D)) / (2 * A);
                if (K1 == K2)
                    return String.Format("{0:0.0}", K1);
                else
                    return String.Format("{0:0.0}", K1) + " " + String.Format("{0:0.0}", K2);
            }
        }
        public override string ToString()
        {
            return Korni();
        }
    }
}
