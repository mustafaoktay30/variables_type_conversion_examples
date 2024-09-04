namespace Ödev_degiskenler_operatörler_tipdönüşümler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru1
            // Verilen iki tam sayıyı toplama işlemi ile birleştirip sonucu ekrana yazdıran program.
            // int sayi1,sayi2;
            //Console.WriteLine("Birinci sayıyı giriniz: ");
            // sayi1 = Convert.ToInt32(Console.ReadLine()) ;
            //Console.WriteLine("İkinci sayıyı giriniz: ");
            // sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(sayi1 + "  " + sayi2);
            #endregion

            #region Soru2
            // Bir string değişkenini integer'a çevirip 5 ile çarpan bir program yazınız.

            //Console.WriteLine("Bir sayı giriniz: ");
            //int  donüştürülensayi = Convert.ToInt32(Console.ReadLine());
            // yukarda yaptığım işlem kullanıcadan gelen string değeri int çevirdim.
            //int islem = donüştürülensayi * 5;

            //Console.WriteLine("Sonuç: " + islem );

            #endregion

            #region Soru3
            // Bir kullanıcıdan aldığı iki string sayıyı toplama işlemi yaparak sonucu ekrana yazdıran bir program yazınız.

            //Console.WriteLine("Birinci sayıyı giriniz:");
            //int stringsayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz: ");
            //int stringsayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplama = stringsayi1 + stringsayi2;
            //Console.WriteLine("Sonuç: " + toplama);

            // Düşüncem ve ilerlediğim yol bir kullanıcıdan aldığım 2 sayı değeri zaten string bir ifadeyle 
            // geldiği için string ifadelerle işlem yapamıcağım için int değerine döndürüp 
            // toplamını öyle gerçekleştirdim.

            //Farklı bir yöntem varsada bulamadım.




            #endregion

            #region Soru4
            // Bir string sayıyı önce integer'a, sonra bu integer'ı double'a çevirip
            // 2.5 ile çarparak sonucu ekrana yazdıran bir program yazınız.


            //string sayi1 = "30";
            //int donusturelenSayi1 = int.Parse(sayi1);
            //double donusturulenSayı1 = double.Parse(sayi1);

            //double islem = donusturulenSayı1*2.5;

            //Console.WriteLine("Sonuc:  " + islem);


            #endregion

            #region Soru5
            //Kullanıcıdan aldığı bir sayıyı önce string'e sonra tekrar integer'a çeviren ve bu sayıyı 10 ile toplama işlemi yaparak sonucunu ekrana yazdıran program.


            //Console.Write("Sayı giriniz: ");
            //string sayi1 = Console.ReadLine();
            //int donusturulenSayi1 = int.Parse(sayi1);
            //int islem = donusturulenSayi1 + 10;
            //Console.WriteLine("Sonuc:  " + islem);


            #endregion

            #region Soru6
            //Bir mağazada her ay 50 adet ürün satılıyor.6 ay boyunca satılan toplam ürün miktarını ve fiyatını hesaplayan bir program yazınız.
            //Ürün fiyatı = 20 TL
            //int aylıkSatılanÜrünAdedi = 50, ürünFiyatı = 20, toplamSatılanÜrünAdedi, toplamFiyat;

            //toplamSatılanÜrünAdedi = aylıkSatılanÜrünAdedi * 6;
            //toplamFiyat = toplamSatılanÜrünAdedi * ürünFiyatı;

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Toplam Satılan Ürün Miktarı:  " + toplamSatılanÜrünAdedi +"   "+ "Toplam Fiyat: " + toplamFiyat);
            //Console.ForegroundColor = ConsoleColor.White;



            #endregion

            #region Soru7
            //Mustafa,20 TL'sini dolara çevirmek istiyor.Dolar kuru şu anda 7.5 TL.Mustafa kaç dolar alabilir hesaplayan program.


            //double dolar = 7.5, mustafanınParası = 20, donusturulenTutar;

            //donusturulenTutar = mustafanınParası / dolar;
            //donusturulenTutar = Math.Round(donusturulenTutar,2); //Virgülden sonra 2 basamak yazdırma

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Mustafa'nın elde ettiği dolar: " + donusturulenTutar);
            //Console.ForegroundColor = ConsoleColor.White;

            #endregion

            #region Soru8
            // muz kg fiyatı = 15.5 TL Mustafa 3 kg muz almak istiyor kasaya geldiğinde ödeceği tutarı hesaplayan program.
            //double muzKgFiyatı = 15.5, alınanMuzMiktarı = 3, odenecekTutar;

            //odenecekTutar = muzKgFiyatı * alınanMuzMiktarı;

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Ödenecek Tutar:  " + odenecekTutar);
            //Console.ForegroundColor = ConsoleColor.White;

            // muz kg fiyatı = 15.5 TL  muz alan kişinin  kasaya geldiğinde ödeceği tutarı hesaplayan program.

            //double muzKgFiyatı = 15.5, alınanMuzMiktarı , odenecekTutar;

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("Tarttığınız muzun kaç kilogram olduğunu yazınız:  ");
            //alınanMuzMiktarı = double.Parse(Console.ReadLine());
            //odenecekTutar=alınanMuzMiktarı*muzKgFiyatı;
            //odenecekTutar = Math.Round(odenecekTutar,2);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Ödeyeceğiniz tutar:  " +odenecekTutar + " TL");
            //Console.ForegroundColor = ConsoleColor.White;


            #endregion

            #region Soru9
            //Bir şirket çalışanlarının maaşlarına yıllık %10 zam yapıyor.mevcut maaşı 5000 TL olan bir çalışanın bir yıl sonraki maaşını hesaplayan program yazınız.

            //double ilkMaas = 5000, zamOranı = 0.10, sonMaas,gelenZam;

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Şu anki maaşınız: "+ilkMaas +" TL");

            //gelenZam = ilkMaas * zamOranı;
            //Console.ForegroundColor= ConsoleColor.Green;
            //Console.WriteLine("Gelicek zam: "+ gelenZam+" TL");

            //sonMaas = ilkMaas + gelenZam;
            //Console.WriteLine("Zamlı alacağınız Maaş:  "+sonMaas+" TL");
            //Console.ForegroundColor=ConsoleColor.White;




            #endregion

            #region Soru10
            //Bir kişinin doğum yılını kullanıcıdan alarak,kaç yaşında olduğunu hesaplayan program yazınız.

            //int olduğumuzYıl = 2024 ,yas ;
            //Console.Write("Hangi yılda doğdunuz:  ");
            //int girilenDogumYılı = int.Parse(Console.ReadLine());
            //yas = olduğumuzYıl - girilenDogumYılı;

            //Console.WriteLine("Yaşınız: "+yas);

            #endregion

            #region Soru11
            //Bir markette müşteri üç farklı ürün alıyor.Bu ürünlerin fiyatlarını ve miktarlarını kullanıcıdan alarak toplam tutarı hesaplayan bir program yazınız.

            //int alınanÜrün1, alınanÜrün2, alınanÜrün3, toplamFiyat,alınanÜrünMiktar1, alınanÜrünMiktar2, alınanÜrünMiktar3, alınanÜrünFiyat1, alınanÜrünFiyat2, alınanÜrünFiyat3;
            //Console.WriteLine("Aldığınız ilk ürünün fiyatı nedir ? ");
            //alınanÜrün1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kaç tane aldınız ?");
            //alınanÜrünMiktar1 = int.Parse(Console.ReadLine());
            //alınanÜrünFiyat1 = alınanÜrün1 * alınanÜrünMiktar1;

            //Console.WriteLine("Aldığınız ikinci ürünün fiyatı nedir ? ");
            //alınanÜrün2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kaç tane aldınız ?");
            //alınanÜrünMiktar2 = int.Parse(Console.ReadLine());
            //alınanÜrünFiyat2 = alınanÜrün2 * alınanÜrünMiktar2;

            //Console.WriteLine("Aldığınız üçüncü ürünün fiyatı nedir ?");
            //alınanÜrün3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kaç tane aldınız ?");
            //alınanÜrünMiktar3 = int.Parse(Console.ReadLine());
            //alınanÜrünFiyat3 = alınanÜrün3 * alınanÜrünMiktar3;

            //toplamFiyat = alınanÜrünFiyat1 + alınanÜrünFiyat2 + alınanÜrünFiyat3;

            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("Aldığınız ürünlerin toplam fiyatı: "+toplamFiyat+" TL");






            #endregion

            #region Soru12
            //Bir öğrencinin üç farklı sınav notunu kullanıcıdan alarak,sınavların ortalamasını hesaplayan ve sonucu ekrana yazdır.

            //double not1, not2, not3, ortalama;
            //Console.Write("İlk sınav notunu giriniz:");
            //not1=double.Parse(Console.ReadLine());
            //Console.Write("İkinci sınav notunu giriniz:");
            //not2=double.Parse(Console.ReadLine());
            //Console.Write("Üçüncü sınav notunu giriniz:");
            //not3=double.Parse(Console.ReadLine());

            //ortalama = (not1 + not2 + not3)/3;
            //ortalama = Math.Round(ortalama,2);

            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("Ortalamanız:"+ortalama);
            #endregion

            #region Soru13
            //Bir mağazada bir ürünün fiyatı üzerinden  %20 indirim yapılmaktadır.Kullanıcıdan ürünün fiyatını alarak indirimli fiyatı hesaplayan program yazınız.

            //double indirimliFiyat, uygulananİndirim, indirimOranı = 0.20, alınanÜrün;
            //Console.Write("Aldığınız ürünün fiyatını giriniz =   ");
            //alınanÜrün = double.Parse(Console.ReadLine());
            //uygulananİndirim = alınanÜrün * indirimOranı;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("Uygulanan İndirim Tutarı: " + uygulananİndirim);
            //indirimliFiyat = alınanÜrün - uygulananİndirim;
            //Console.ForegroundColor= ConsoleColor.Red;
            //Console.WriteLine("Ödeyeceğiniz Tutar: " + indirimliFiyat);

            //Console.ForegroundColor=ConsoleColor.White;



            #endregion

            #region Soru14
            //Kullanıcıdan girilen Euro para birimini güncel kurla hesaplayıp kaç TL karşılık geldiğini hesaplayan program yazınız.

            //double euroKur = 37.62, girilenEuro, verilenTl;
            //Console.Write("Bozdurmak istediğiniz Euro girişini yapınız: ");
            //girilenEuro = double.Parse(Console.ReadLine());
            //verilenTl = girilenEuro * euroKur;
            //verilenTl = Math.Round(verilenTl);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(verilenTl+" TL");

            //Console.ForegroundColor= ConsoleColor.White;
            #endregion
        }
    }
}
