namespace AtlamaOperatörleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atlama ifadeleri (Jump Statements) program kontrolü üzeride akışta dallanmalar sağlanmak için kullanılır
            // - Break
            // - Continue
            // - Goto
            // - Return
            // - Throw

            #region Break
            //Break anahtar kelimesi döngü içinde kullanıldığı zaman bir daha dönmemek üzere döngünün sonuna gönderir.

            for (int i = 0;  i < 10; i++)
            {
                if (i == 5)
                {
                   break
                }
                Console.WriteLine(i);
            }

            
            #endregion
        }
    }
}
