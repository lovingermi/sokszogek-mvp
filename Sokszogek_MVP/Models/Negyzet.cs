using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Models
{
    public class Negyzet 
    {
        public double oldalA { get; set; }
        public Negyzet(double A)
        {
            oldalA = A;
        }
        public double Kerulet()
        {
            return 4 * oldalA;
        }

        public double Terulet()
        {
            return oldalA * oldalA;
        }

    }
}
