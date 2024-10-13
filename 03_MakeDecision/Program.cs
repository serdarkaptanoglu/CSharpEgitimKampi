using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakeDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If

            //Console.Write("Lutfen sifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis");
            //}

            //string capital, country;
            //Console.Write("Baskenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Dogrulandi.");
            //}
            //else
            //{
            //    Console.Write("Hatali bilgi..");
            //}

            //int number;
            //Console.Write("Sayi giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("Sayi dogru...");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi hatali..");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Sinav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinavlarin Ortalamasi: " + average);

            //if (average > 0 & average <= 49)
            //{
            //    result = "Sonuc Vasat..";
            //}
            //if (average > 50 & average <= 69)
            //{
            //    result = "Sonuc Orta..";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuc Iyi..";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuc Cok Iyi..";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lutfen bir sehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Sehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Sehir mevcut degildir..");
            //}

            //Console.Write("Kullanici adi giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanici kabul edilemez...");
            //}
            //else
            //{
            //    Console.Write("Hosgeldiniz...");
            //}

            #endregion

            #region Mod İslemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lutfen 1. sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayinin 2. sayiya bolumundan kalan: " + result);

            //Console.Write("Lutfen bir sayi giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayi cifttir");
            //}
            //else
            //{
            //    Console.Write("Sayi tektir");
            //}

            #endregion

            #region Char Degiskenler ile Karar Yapilari

            //char team;
            //Console.Write("Lutfen takim sembolunu giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Besiktas");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.WriteLine("Trabzonspor");
            //}

            #endregion

            #region Ornek Proje Uygulamasi

            //Console.WriteLine("***** C# Egitim Kampi Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayini gormek istediginiz menu secimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma Tabagi");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Firinda Somon");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Corbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezo Gelin Corbası");
            //    Console.WriteLine("----------Corbalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Icecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------Icecekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlilar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilice");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sutlac");
            //    Console.WriteLine("----------Tatlilar----------");
            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lutfen Ay Girisi Yapiniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Subat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayis"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylul"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasim"); break;
            //    case 12: Console.Write("Aralik"); break;
            //    default:Console.Write("Hatali Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayiyi giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayiyi giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediginiz islemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpma: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;
            //}

            #endregion


            Console.Read();
        }
    }
}
