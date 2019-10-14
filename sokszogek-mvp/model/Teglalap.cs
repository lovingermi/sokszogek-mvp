using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokszogek_mvp.model
{
    public class Teglalap : Sokszog
    {

        public Teglalap(double A, double B):base(A,B)
        {

        } 

        public override double kerulet()
        {
            return (oldalA + oldalB) * 2;
        }

        public override double terulet()
        {
            return oldalA * oldalB;
        }
    }
}
