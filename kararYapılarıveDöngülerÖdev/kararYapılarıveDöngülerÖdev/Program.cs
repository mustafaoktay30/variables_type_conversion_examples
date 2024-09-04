using System.Collections.Concurrent;

namespace kararYapılarıveDöngülerÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Basit Hesap Makinesi

        // Kullanıcıdan iki sayı ve bir işlem türü(+, -, *, /) alın.Girilen işleme göre iki sayının sonucunu ekrana yazdıran bir program yazın.Eğer kullanıcı geçersiz bir işlem girerse, uygun bir hata mesajı gösterin.
        label1:
            
            Console.Write("Birinci Sayıyı Giriniz: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz:  ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hangi işlemi yapmak istiyorsanız onu yazın. [+] [-] [%] [*]");
            string islem = Console.ReadLine();
            if (islem == "+")
            {
                int toplama = number1 + number2;
                Console.WriteLine("Sonucunuz: " +toplama);
            }
            else if (islem == "-")
            {
                int çıkarma = number1 - number2;
                Console.WriteLine("Sonucunuz: " + çıkarma);
            }
            else if (islem == "%")
            {
                double bölme = number1 % number2;
                Console.WriteLine("Sonucunuz:  " + bölme);
            }
            else if (islem == "*")
            {
                int çarpma = number1 * number2;
                Console.WriteLine("Sonucunuz:  " + çarpma);
            }
            else
            {
                Console.WriteLine("Yanlış bir tuşlama yaptınız.");
                goto label1;
            }


            #endregion


        }
    }
}
