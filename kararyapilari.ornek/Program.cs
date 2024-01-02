using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kararyapilari.ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   = değer atar                    && ve                  > büyüktür
                 + toplama                       || veya                < küçüktür
                 - çıkarma                       ! değil                >= büyük eşit
                 * çarpma                                               <= küçük eşit
                 / bölme                                                == eşit
                 % mod alma (kalan değeri gösterir)                     != farklı
                 -- bir azaltma
                 ++ bir artırma
            */

            //Console.WriteLine("birinci notu giriniz");

            //int birincinot=Convert.ToInt32(Console.ReadLine());
            //int ikincinot = Convert.ToInt32(Console.ReadLine());
            //int ucuncunot = Convert.ToInt32(Console.ReadLine());
            //int sonuc= (birincinot + ikincinot + ucuncunot)/3;
            // if (sonuc>=80 && sonuc <=100)
            //{
            //    Console.WriteLine( "not değeriniz:A+");

            //}                                                 // else if koşulunda iikiden fazla koşul varsa else if kullanılır
            //                                                  // son koşula kadar else yazılmaz else de parantez içi boş kalır
            // else if (sonuc>=60 && sonuc <=79)
            //{
            //    Console.WriteLine("not değeriniz:A");       // değerlerle matematiksel işlem yapılacağı için string veri tipinden
            //                                                    // int veri tipine "convert" yolu ile dönüşüm yapıldı.
            //}
            //else if (sonuc >=40 && sonuc <=59)
            //{
            //    Console.WriteLine("not değeriniz:B+");
            //}
            // else
            //{
            //    Console.WriteLine("not değeriniz:F");
            //}

            /*kullanıcıya hangi işlemi yapmak istediğini sor
             1-bakiye görüntüleme
            2-para çekme
            3-para yatırma
            4- q ya basım çıkış yapma */

            //int bakiye = 2000;
            //Console.WriteLine("HOŞGELDİNİZ:)");
            //Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            //string islem= Console.ReadLine();
            // if (islem=="1")
            //{
            //    Console.WriteLine("bakiyeniz:"+bakiye);               // ekranda kalması için console.Readline(); mrtofunu kullan.
            //    Console.ReadLine();
            //}
            // else if (islem=="2")
            //{
            //    Console.WriteLine("çekmek istediğiniz tutarı giriniz:");
            //    int tutar=int.Parse(Console.ReadLine());

            //    Console.WriteLine("kalan tutar:"+(bakiye- tutar));
            //    Console.ReadLine();

            //}
            // else if (islem=="3")
            //{
            //    Console.WriteLine("miktar giriniz:");
            //    int miktar = int.Parse(Console.ReadLine());
            //    Console.WriteLine("parayı gösterilen şekilde hazneye koyunuz.");
            //    Console.ReadLine();
            //    Console.WriteLine("bakiye öğrenmek için devam tuşuna basınız.");
            //    Console.ReadLine();
            //    Console.WriteLine("son bakiyeniz:"+(bakiye+miktar ));
            //   int son_bakiye=int.Parse(Console.ReadLine());
            //}
            //else if(islem=="4") 
            //{
            //    Console.WriteLine("çıkış yapmak için 'q'ya basınız.");
            //    Console.ReadLine();
            //    Console.WriteLine("çıkış yapılıyor");
            //    Console.WriteLine("Allah'a emanet olun -_<");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("lütfen geçerli bir işlem yapınız.");
            //    Console.ReadLine();
            //}


            /* Beden kitle indeksi=kilo/boy*boy 
              beden kitle indeksi eşit veya düşükse zayıf
              18 25 arasında ise normal
              25 ten büyükse obez yazan program
            */



            //Console.WriteLine("kilonuzu giriniz:");
            //int kilo = int.Parse(Console.ReadLine());
            //Console.WriteLine("boyunuzu giriniz:");
            //double boy = Convert.ToDouble(Console.ReadLine());
            //double bke = kilo / (boy * boy);
            //if (bke <= 18)
            //{
            //    Console.WriteLine("zayıfsınız");
            //    Console.ReadLine();                                   // her programda else kullanmak zorunda değiliz .
            //}
            //else if(bke>18 && bke < 25)
            //{
            //    Console.WriteLine("normal kilodasınız");
            //    Console.ReadLine();
            //}
            //else if(bke>25)
            //{
            //    Console.WriteLine("obezsiniz");
            //    Console.ReadLine();
            //}
            // SWİTCH CASE YAPILARI

            //int bakiye = 8000;
            //Console.WriteLine("HOŞGELDİNİZ");
            //Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            //Console.WriteLine("1-bakiye sorgulama");
            //Console.WriteLine("2-para çekme");
            //Console.WriteLine("3-para yatırma");
            //Console.WriteLine("4-çıkış yapma");
            //                                                                     // switch case yapısında break koymazsak her kodu sıra ile çalıştırır .
            //string secim = Console.ReadLine();

            //switch (secim)
            //{
            //    case "1":
            //        Console.WriteLine("bakiyeniz:" + bakiye);
            //        Console.ReadLine();
            //        break;

            //    case "2":
            //        Console.WriteLine("çekmek istediğiniz tutar giriniz");
            //        int tutar = int.Parse(Console.ReadLine());

            //        if (tutar > bakiye)
            //        {
            //            Console.WriteLine("Bakiyenizin üstünde para çekemezsiniz.");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kalan tutarınız:" + (bakiye - tutar));
            //            Console.ReadLine();
            //        }
            //        break;

            //    case "3":
            //        Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
            //        int yatirilantutar = int.Parse(Console.ReadLine());
            //        Console.WriteLine("bakiye:" + (bakiye + yatirilantutar));
            //        Console.ReadLine();
            //        break;

            //    case "4":
            //        Console.WriteLine("çıkış yapıldı.");
            //        Console.WriteLine("iyi günler dileriz:)");
            //        Console.ReadLine();
            //        break;

            //    default:

            //        Console.WriteLine("Geçerli bir sonuç giriniz");
            //        Console.ReadLine();
            //        break;
            //}

            // 1-10 arası sayıları for döngüsü ile yazdır.
            /* for döngüsünde veri tipini yaz değeri gir başlangıç değerini belirle
//FOR DÖNGÜSÜ                                                           * nereye kadar devam etsin onu belirle 
             * kaç artırsın onu belirle console.writeline ile değeri ata condole.Readline ile sabitle.
//                                                                      */
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            // 1 den 10 a kadar olan sayıları çift olarak yazdır

            //for (int i = 0; i <=10; i=i+2)                 // a=a+2  ile a+=2 birbirine eşittir.
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //for (int i = 0; i <=10; i++)
            //{
            //    for(int j = 1; j <=i; j++)                   // console.writeline ile alt tarafa geçti.Boşluk olması ekrana bir şey yazdırmasın diye.
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            /*
            int a = 1;
            while (a<=10)
            {                                 //Eğer sayaç kullanmasaydık sonsuz döngüye girecekti.
                Console.WriteLine(a);
                a++;
            }Console.ReadLine(); */

            // 100 den 0 a kadar olan sayıların çift olanlarını büyükten küçüğe doğru yazınız.
            /*
            int a = 100;

            while (a>=0)
            {                                   // a-=2 kısmını iki iki azaltsın diye koyduk ayrıca a=a-2 de buna eşittir.
                Console.WriteLine(a);            
                a-=2;

            }Console.ReadLine(); */







        }
    }
}
