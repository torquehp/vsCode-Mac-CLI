// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hoş geldiniz!");
        Console.WriteLine("Lütfen adınızı girin:");
        string ad = Console.ReadLine();

        Console.WriteLine("Merhaba, " + ad + "! Kaç yaşındasınız?");
        int yas = Convert.ToInt32(Console.ReadLine());

        if (yas < 18)
        {
            Console.WriteLine("Üzgünüz, bu programı kullanabilmek için 18 yaşından büyük olmalısınız.");
        }
        else
        {
            Console.WriteLine("Harika, " + ad + "! Programı kullanmaya devam edebilirsiniz.");
            Console.WriteLine("Lütfen bir sayı girin:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayının karesi: " + (sayi * sayi));
        }

        Console.WriteLine("Programdan çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
