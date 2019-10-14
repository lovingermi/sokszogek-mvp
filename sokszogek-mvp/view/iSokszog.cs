using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokszogek_mvp.view
{
    public interface iSokszog
    {
        string oldalA { get; set; }
        string oldalB { get; set; }
        string Kerulet { get; set; }
        string Terulet { get; set; }
        IList<string>SokszogList { get; set; }
    }
}
