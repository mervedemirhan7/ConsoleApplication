using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.Lib
{
    public class SatilikEv:Ev
    {
        //public SatilikEv(string semt,double alan,int katno,int odasayisi,double satisfiyati )  //Constructor
        //{
        //    base.Semt = semt;
        //    base.Alan = alan;
        //    base.Katno = katno;
        //    base.Odasayisi = odasayisi;
        //    this.Satisfiyati = satisfiyati;
        //}
        //Yukarıdaki constructor'ın kısa hali aşağıdaki gibidir


        public SatilikEv(string semt, int katno, int odasayisi, double alan, double satisfiyati) : base(semt, katno, odasayisi, alan)
        {
            this.Satisfiyati = satisfiyati;
        }

        public SatilikEv()
        {
        }

        double satisfiyati;
        public double Satisfiyati
        {
            get
            {
                return satisfiyati;
            }

            set
            {
                satisfiyati = value;
            }
        }
        //public new string EvBilgileriniGetir()
        //{
        //    return base.EvBilgileriniGetir() + "\nSatis Fiyatı:" + this.satisfiyati; //Name Hiding sadece satılık ev bilgilerini getir
        //}

            //yukarıdaki metodun override edilmiş hali
        public override string EvBilgileriniGetir()
        {
            return base.EvBilgileriniGetir() + "\nSatis Fiyatı:" + this.satisfiyati;
        }
    }
}
