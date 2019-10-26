using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Views
{
    interface INegyzetView
    {
        string oldalA { get; set; }
        string Kerulet { get; set; }
        string Terulet { get; set; }
    }
}
