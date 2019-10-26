using Sokszogek_MVP.Models;
using Sokszogek_MVP.Repositories;
using Sokszogek_MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Presenters
{
    class SokszogPresenter
    {
        private ISokszogView sokszogView;
        private IHaromszog haromszogView;
        private INegyzetView negyzetView;
        private ISokszogRepository sokszogRepository;
        private string sokszogNev;
        public bool oldal_C_Letezik;
        public bool oldal_B_Letezik;
        public bool oldal_A_Letezik;

        public SokszogPresenter(ISokszogView sokszogV,IHaromszog haromszogV, INegyzetView negyzetV)
        {
            sokszogView = sokszogV;
            haromszogView = haromszogV;
            negyzetView = negyzetV;
            sokszogRepository = new SokszogRepository();
        }
        public void LoadData()
        {
            sokszogView.SokszogList = sokszogRepository.GetSokszogek();
        }
        public void ShowOldal(int index)
        {
            sokszogNev = sokszogRepository.GetNameByIndex(index);
            switch (sokszogNev)
            {
                case "Négyzet":
                    oldal_A_Letezik = true;
                    oldal_C_Letezik = false;
                    oldal_B_Letezik = false;
                    break;
                case "Téglalap":
                    oldal_A_Letezik = true;
                    oldal_B_Letezik = true;
                    oldal_C_Letezik = false;
                    break;
                case "Háromszög":
                    oldal_A_Letezik = true;
                    oldal_B_Letezik = true;
                    oldal_C_Letezik = true;
                    break;

                default:
                    oldal_A_Letezik = true;
                    oldal_B_Letezik = true;
                    oldal_C_Letezik = true;
                    break;
            }
        }
        public void Calculate()
        {
            if (sokszogNev== "Téglalap"&&(string.IsNullOrWhiteSpace(sokszogView.oldalA)
                || string.IsNullOrWhiteSpace(sokszogView.oldalB)))
            {
                return;
            }
            if (sokszogNev == "Háromszög" && (string.IsNullOrWhiteSpace(sokszogView.oldalA)
                || string.IsNullOrWhiteSpace(sokszogView.oldalB)|| string.IsNullOrWhiteSpace(haromszogView.oldalC)))
            {
                return;
            }
            if (sokszogNev == "Négyzet" && (string.IsNullOrWhiteSpace(negyzetView.oldalA)))
            {
                return;
            }
            switch (sokszogNev)
            {
                case "Téglalap": var teglalap = new Teglalap(Convert.ToDouble(sokszogView.oldalA), Convert.ToDouble(sokszogView.oldalB));
                    sokszogView.Kerulet = teglalap.Kerulet().ToString();
                    sokszogView.Terulet = teglalap.Terulet().ToString();
                    break;
                case "Háromszög": var haromszog = new Haromszog(Convert.ToDouble(sokszogView.oldalA), Convert.ToDouble(sokszogView.oldalB), Convert.ToDouble(haromszogView.oldalC));
                    sokszogView.Kerulet = haromszog.Kerulet().ToString();
                    sokszogView.Terulet = haromszog.Terulet().ToString();
                    break;
                case "Négyzet": var negyzet = new Negyzet(Convert.ToDouble(negyzetView.oldalA));
                    negyzetView.Kerulet = negyzet.Kerulet().ToString();
                    negyzetView.Terulet = negyzet.Terulet().ToString();
                    break;
                default:
                    sokszogView.Kerulet = null;
                    sokszogView.Terulet = null;
                    break;
            }
        }
    }
}
