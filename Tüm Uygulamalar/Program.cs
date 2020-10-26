using System;

namespace Tüm_Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            int u;
            Bas:
            Console.WriteLine("\nUyugulama Seçiniz\n");
            Console.WriteLine("1 = İki Sayıdan büyük olanı bulan\n2 = Çarpım tablosu\n3 = Vize ve Final\n4 = Kelimenin Uzunluğunu Bulan\n5 = Çarpmayı Toplayarak Yapan\n");
            u=Convert.ToInt32(Console.ReadLine());
            if(u == 1)
            {
                int a, b;
                Console.WriteLine("1.Sayıyı Girin");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayıyı Girin");
                b = Convert.ToInt32(Console.ReadLine());
                if (a == b)
                {
                    Console.Write("Sayılar birbirine eşit " + a + " = " + b);
                }
                else
                {
                    if (a > b)
                    {
                        Console.Write("Büyük olan sayı = " + a);
                    }
                    else
                    {
                        Console.Write("Büyük olan sayı = " + b);
                    }
                }
            }
            else if (u == 2)
            {
                int a, i, j;
                Console.WriteLine("--------------Çarpım Tablosunu Açtınız--------------\n");
                for (i = 1; i <= 10; i++)
                {
                    for (j = 1; j <= 10; j++)
                    {
                        a = i * j;
                        Console.Write("{0}*{1}={2}\t", j, i, a);
                    }
                    Console.WriteLine("");
                }
            }
            else if (u == 3)
            {
                double v, f, o;
                Console.Write("Vize Notunuzu Giriniz: ");
                v = Convert.ToDouble(Console.ReadLine());
                Console.Write("Final Notunuzu Giriniz: ");
                f = Convert.ToDouble(Console.ReadLine());
                o = (v * 0.4) + (f * 0.6);
                Console.WriteLine("Ortalamanız: " + o);
            }
            else if (u == 4)
            {
                string a;
                int b;
                Console.Write("Kelime Uzunuluğunu Bulma\n");
                Console.Write("\nKelimeyi Giriniz: ");
                a = Console.ReadLine();
                b = a.Length;
                Console.WriteLine("\nKelimenin Uzunluğu: " + b);
            }
            else if (u == 5)
            {
                int a, b, c = 0, i;
                Console.WriteLine("Çarpmayı toplayarak yapan program\n");
                Console.Write("1. Sayıyı Giriniz: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n2. Sayıyı Giriniz: ");
                b = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= b; i++)
                {
                    c += a;
                }
                Console.WriteLine("\n" + c);
            }
            goto Bas;
        }
    }
}
