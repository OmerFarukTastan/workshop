using System;
using System.Collections.Generic;
using System.Text;



class Product
{
    public string UrunAdı { get; set; }

    public int UrunYılı { get; set; }

    public int UrunFiyati { get; set; }
}


public class Urunler
{
    static void Main(string[] args)
    {
        Product product = new Product();
        product.UrunAdı = "kamera";
        product.UrunYılı = 2000;
        product.UrunFiyati = 200;

        Product product1 = new Product();
        product1.UrunAdı = "modem";
        product1.UrunYılı = 1000;
        product1.UrunFiyati = 100;

        Product product2 = new Product();
        product2.UrunAdı = "mouse";
        product2.UrunYılı = 3000;
        product2.UrunFiyati = 300;

        Product[] products = new Product[] { product , product1 , product2 };

        for (int i = 2; i < products.Length; i++)
        {
            Console.WriteLine(product.UrunAdı + product.UrunYılı + product.UrunFiyati);
            
        }
        
        
        Console.WriteLine("********************");
        
        
        foreach (var p in products)
        {
            Console.WriteLine(product1.UrunAdı + product1.UrunYılı + product1.UrunFiyati);
            break;
        }
        
        
        Console.WriteLine("********************");
        
        
        int a = 2;
        while (a<products.Length)
        {
            Console.WriteLine(product2.UrunAdı + product2.UrunYılı + product2.UrunFiyati);
            
            a++;
        }

        Console.ReadLine();
    }
}

