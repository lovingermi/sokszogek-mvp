using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokszogek_mvp.model
{
    public abstract class Sokszog
    {
        public double oldalA { get; set; }
        public double oldalB { get; set; }

        public abstract double kerulet();
        public abstract double terulet();

        public Sokszog(double a, double b)
        {
            oldalA = a;
            oldalB = b;
        }
    }
}
