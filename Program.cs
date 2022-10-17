using System;


namespace workshop
{
    class Program
    {
        static void main()
        {
            {
                Product Urun1 = new Product();
                Urun1.UrunAdı = "kamera";
                Urun1.UrunYılı = 1950;
                Urun1.UrunFiyati = 15;

                System.Console.WriteLine(Urun1);

                Product Urun2 = new Product();
                Urun2.UrunAdı = "modem";
                Urun2.UrunYılı = 2000;
                Urun2.UrunFiyati = 80;

                System.Console.WriteLine(Urun2);
            }
        }
    }
    
}


public class Product
{
    public string UrunAdı { get; set; }

    public int UrunYılı { get; set; }

    public int UrunFiyati { get; set; }
}