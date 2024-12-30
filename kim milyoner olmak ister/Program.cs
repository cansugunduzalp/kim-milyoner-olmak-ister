using System;

class Program
{
    static void Main()
    {
        int dogruCevapSayisi = 0;
        string cevap;

        // 1. Soru
        Console.Clear(); // Ekranı temizleyerek yeni soru gösteriyoruz
        Console.WriteLine("1 -> Dünyanın en bilinen müzik notası nedir?");
        Console.WriteLine("a) Do b) Re");
        cevap = Console.ReadLine()?.ToLower(); // Kullanıcıdan cevabı alıyoruz ve küçük harfe çeviriyoruz
        if (cevap == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: a) Do");
        }

        // 2. Soru
        Console.WriteLine("\nDevam edelim..."); // Kullanıcıya bir bilgi veriyoruz
        Console.ReadKey(); // Kullanıcı herhangi bir tuşa basana kadar bekliyoruz (ekranı geçmek için)

        Console.Clear(); // Ekranı temizleyerek yeni soru gösteriyoruz
        Console.WriteLine("2 -> Hangi ünlü müzik aleti, 88 tuşlu bir klavyeye sahiptir?");
        Console.WriteLine("a) Piyano b) Org");
        cevap = Console.ReadLine()?.ToLower(); // Kullanıcıdan cevabı alıyoruz ve küçük harfe çeviriyoruz
        if (cevap == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: a) Piyano");
        }

        // Eğer 2 doğru cevap alındıysa, 3. soruya geçmiyoruz
        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("\nTebrikler! Büyük ödül kazandınız! 1 Milyon TL!");
            return; // 3. soruya geçmemek için çıkıyoruz
        }

        // 3. Soru
        Console.WriteLine("\nDevam edelim..."); // Kullanıcıya bir bilgi veriyoruz
        Console.ReadKey(); // Kullanıcı herhangi bir tuşa basana kadar bekliyoruz (ekranı geçmek için)

        Console.Clear(); // Ekranı temizleyerek yeni soru gösteriyoruz
        Console.WriteLine("3 -> Hangi müzik türü, 1950'lerde Amerika'da popülerleşmiştir?");
        Console.WriteLine("a) Rock b) Jazz");
        cevap = Console.ReadLine()?.ToLower(); // Kullanıcıdan cevabı alıyoruz ve küçük harfe çeviriyoruz
        if (cevap == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruCevapSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: a) Rock");
        }

        // Final sonucu
        if (dogruCevapSayisi >= 2)
        {
            Console.WriteLine("\nTebrikler! Büyük ödül kazandınız! 1 Milyon TL!");
        }
        else
        {
            Console.WriteLine("\nMaalesef, büyük ödülü kazanamadınız. Daha şanslı bir zaman!");
        }
    }
}
