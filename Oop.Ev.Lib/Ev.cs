using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.Lib
{
    public class Ev
    {
       static int sayac = 0; //Nesneden bağımsız class adıyla ulaşılabiliyor

        public Ev()
        {
            sayac++;
        }
        public Ev(int katno, int odasayisi, double alan)  //Sadece semt sabit olsun
        {
            this.Semt = "Kızılay";
            this.Katno = katno;
            this.Odasayisi = odasayisi;
            this.Alan = alan;
            sayac++;
        }
        public Ev(string semt,int katno,int odasayisi,double alan) //Yapıcı Metod-Kurucu Metod-Constructor(class içindeki field'lara değer atamasak bile varsayılan değerleri atar.Bir classtan nesne türettiğimiz an çalışır(ctor+tabtab)
        {
            this.Semt = semt;
            this.Odasayisi = odasayisi;
            this.Alan = alan;
            this.Katno = katno;
            sayac++;
        }
        int odasayisi;
        string semt;
        double alan;
        //int katno;
        public int Katno { get; set; }


        public int Odasayisi 
        {
            get
            {
                return odasayisi;
            }

            set
            {
                odasayisi = Math.Abs(value);
            }
        }

        public string Semt
        {
            get
            {
                return semt;
            }

            set
            {
                semt = value;
            }
        }

        public double Alan
        {
            get
            {
                return alan;
            }

            set
            {
                alan = value;
            }
        }

        public static int Sayac
        {
            get
            {
                return sayac;
            }                                                   //değerini değiştirmemek sadece okunabilir yapmak için 
        }



        //public int Katno
        //{
        //    get
        //    {
        //        return katno;
        //    }

        //    set
        //    {
        //        katno = value;
        //    }
        //}

        public virtual string EvBilgileriniGetir() //Ezmek istediğimiz metodu "virtual" yapıyoruz
        {
            return "Oda Sayısı:" + this.Odasayisi.ToString() + "\nSemt" + this.Semt + "\nAlan" + this.Alan.ToString() + "\nKat No:" + this.Katno.ToString(); //Field'ı Property'e çevirdiğimiz anda bu alandaki baş harfler büyür.
        }
    }
     
}