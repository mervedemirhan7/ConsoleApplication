using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.Lib
{
    public class KiralıkEv:Ev
    {
        //public KiralıkEv(string semt,int katno,int odasayisi,double alan,double kira,double depozito)
        //{
        //    base.Semt = semt;
        //    base.Odasayisi = odasayisi;
        //    base.Katno = katno;
        //    base.Alan = alan;
        //    this.Kira = kira;
        //    this.Depozito = depozito;
        //}
        //Yukarıdaki constructor'ın kısaltılmış hali aşağıdaki gibidir
        public KiralıkEv(string semt, int katno, int odasayisi, double alan, double kira, double depozito):base(semt,katno,odasayisi,alan)  //Constructor
        {
            this.Depozito = depozito;
            this.Kira = kira;
        }
        public KiralıkEv() //Constructor
        {

        }



        double kira;
        double depozito;

        public double Kira
        {
            get
            {
                return kira;
            }

            set
            {
                kira = value;
            }
        }

        public double Depozito
        {
            get
            {
                return depozito;
            }

            set
            {
                depozito = value;
            }
        }
        //public new string EvBilgileriniGetir()      //sadece kiralık evdeki metodu getir (Name Hiding)
        //    //base classsta aynı isimde metod olduğu için name hiding'e özel "new" kullanılır
        //{
        //    return base.EvBilgileriniGetir() + "\nKira :" + this.Kira + "\nDepozito:" + this.Depozito; //base "Ev" class'ı ve base.EvBilgileriniGetir()= ev class'ındaki ev bilgilerini getir metodu
        //}
         //yukarıdaki metodun override edilmiş hali
        public override string EvBilgileriniGetir()
        {
            return base.EvBilgileriniGetir() + "\nKira :" + this.Kira + "\nDepozito:" + this.Depozito;
        }
    }
}
