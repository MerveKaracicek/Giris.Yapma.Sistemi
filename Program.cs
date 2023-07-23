internal class Program
{
    private static void Main(string[] args)
    {
        //Data
        string username = "Merve";
        string password = "210254077";

        Console.WriteLine("Giris yapma sistemine hosgeldiniz: ");
        baslangic:
        Console.WriteLine("Lutfen kullanıcı adinizi giriniz:");
        string kullaniciadi = Console.ReadLine();
        
        if (username != kullaniciadi)
        {
            Console.WriteLine("Kullanici bulunamadi.Lutfen tekrar deneyin");
            goto baslangic;
        }
        else
        {
            baslangic2:
            Console.WriteLine("Lutfen sifrenizi girin:");
            string sifre= Console.ReadLine();

            if (sifre==password)
            {
                Console.WriteLine("Giris basarili.Hosgeldiniz!");

            }
            else
            {
                Console.WriteLine("Yanlis veya eksik sifre girdiniz.Lutfen tekrar deneyin.");
                goto baslangic2;
            }
        }


}            
}