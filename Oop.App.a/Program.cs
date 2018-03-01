using Emlakci.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmlakciApp
{
    class Program
    {
        static void Main(string[] args)
        {   Ev evim = new Ev {Alan=120,Katno=2,Semt="Aydınlıkevler",Odasayisi=3 };
            Ev evim2 = new Ev("Aydınlıkevler", 2, -3, 100); //Constructor ile verilen değer
            Ev evim3 = new Ev(2,3,120); //Semt sabit olacak
            Ev evim4 = new Ev();
            KiralıkEv kev = new KiralıkEv("Kiralık Ev",2,3,120,2500,1500); //Constructor ile verilen değer
            KiralıkEv kev1 = new KiralıkEv { Alan = 100, Depozito = 150, Katno = 3, Odasayisi = 2, Kira = 1000, Semt = "Kiralık Ev" }; //Default constructor ile verilen değer
            KiralıkEv kev2 = new KiralıkEv("Kiralık Ev",5,6,200,1500,1000);
            SatilikEv sev = new SatilikEv("Satilik Ev", 120, 4, 4, 5000); //Constructor ile verilen değer
            SatilikEv sev1 = new SatilikEv("Satilik Ev",3,4,150,150000);
            SatilikEv sev2 = new SatilikEv("Satilik Ev",5,2,120,200000);

            //Console.WriteLine(kev.EvBilgileriniGetir()); //Sadece kiralık evdeki ev bilgilerini getir
            //Console.WriteLine(sev.EvBilgileriniGetir()); //Sadece satılık evdeki ev bilgilerini getir

            

            Ev[] evler = { sev, sev1, sev2, kev, kev1, kev2 }; //Bütün evlerin bilgilerini yazdırmak için ev tipinde dizi oluşturduk           

            for (int i = 0; i < 6; i++)
            {
                //if (evler[i] is KiralıkEv)      //evler[i]'nin tipi     kiralık ev midir?
                //{
                //    KiralıkEv kiralık = (KiralıkEv)evler[i];        //Kiralık= kiralık ev tipinde bir referans (Kiralık ev bilgilerini getirmek için tür dönüşümü yapılıyor)
                //    Console.WriteLine(kiralık.EvBilgileriniGetir());   //Ev tipi olduğu için name hiding sadece ev class'ındaki EvBilgileriniGetir metodunu çalıştırır(Depozito,kira ve satis fiyatı görünmez bunun için kiralık ve satılık ev kontrolü yapmamız gerekir)
                //}
                //else
                //{
                //    SatilikEv satilik = (SatilikEv)evler[i];
                //    Console.WriteLine(satilik.EvBilgileriniGetir());
                //}

                //ev classındaki evbilgilerinigetir metoduna virtual yazıyoruz
                //override yaptığımız için yukarıdaki işlemi aşağıdaki gibi yapabiliriz kendisi if else gibi nesnenin tipini kontrol eder
                //Dizi elemanlarının tipinin satılık mı kiralık mı olduğunu kontrol edip ona göre o class'taki metodu çağırır(Polimoorphism)
                Console.WriteLine(evler[i].EvBilgileriniGetir());
                Console.WriteLine("----------------------------------------");
               
            }
            
            
           


            //evim.Alan = 120;
            //evim.Odasayisi = 3;
            //evim.Katno = 2;
            //evim.Semt = "Kızılay";
           // Ev.Sayac = 15; set blogunu sildiğimiz için değer atayamayız
            //Console.WriteLine(evim.EvBilgileriniGetir());
            //Console.WriteLine(Ev.Sayac);      //static sayaç değişkenine class adıyla ulaşılabilir
            Console.ReadKey();
        }
    }
    
    }
