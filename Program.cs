using System;
namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[]args)
        {
          Calisan calisan1=new Calisan("alper","saçmaözü",123456,"mühendis ofisi");

          calisan1.CalisanBilgileri();

        Console.WriteLine("******************");

          Calisan calisan2=new Calisan();
          calisan2.Ad="ali";
          calisan2.Soyad="veli";
          calisan2.No=4950;
          calisan2.Departman="satın alma";

          calisan2.CalisanBilgileri();
          Calisan calisan3=new Calisan("alper","saçmaözü");
          calisan3.CalisanBilgileri();
        }
        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
            
            public Calisan(string ad,string soyad,int no,string departman)
            {
                this.Ad=ad;
                this.Soyad=soyad;
                this.No=no;
                this.Departman=departman;
            }
            public Calisan(string ad,string soyad)
            {
                this.Ad=ad;
                this.Soyad=soyad;
            }
            public Calisan(){}

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan adı:{0}",Ad);
                Console.WriteLine("Çalışan soyadı:{0}",Soyad);
                Console.WriteLine("Çalışan numarası:{0}",No);
                Console.WriteLine("Çalışan departmanı:{0}",Departman);

            }
        }
    }
}

