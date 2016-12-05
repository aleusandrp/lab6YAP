using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Achievement__Unlocked_Ya_Sel_Za_Labu
{
    class BiKvadrav : Kvadrad
    {
        public BiKvadrav() { }
        public BiKvadrav(double _A, double _B, double _C)
        {
            A = _A;
            B = _B;
            C = _C;
        }

        public override string Korni()
        {
            string Result = base.Korni();
            string K = "";
            string[] Str = Result.Split(' ');
            try
            {
                Double.Parse(Str[0]);
            }
            catch
            {
                return Result;
            }

            for (int i = 0; i < Str.Count(); i++)
            {
                if (Double.Parse(Str[i]) == 0)
                    K += Str[i];
                else if (Double.Parse(Str[i]) > 0)
                    K += String.Format("{0:0.0}", Math.Sqrt(Double.Parse(Str[i]))) + " " + String.Format("{0:0.0}", -Math.Sqrt(Double.Parse(Str[i]))) + "\n";
            }
            if (K == null)
                return "Корней нет";
            return K;
        }
        public override string ToString()
        {
            return Korni();
        }
    }
}
