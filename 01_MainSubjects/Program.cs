using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırmakomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //string name;
            //name = "Serdar";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+905436731206";
            //customerEmail = "alicınar@gmail.com" ; 
            //district = "Bahçelievler"; 
            //city = "İstanbul";

            //Console.WriteLine("**** Rezarvasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon No: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");


            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+901234567";
            //customerEmail = "aysekaya@gmail.com";
            //district = "Merkez";
            //city = "Sinop";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon No: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("-----Patates Kızartması Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totallemonadePrice = 0;
          
            hamburgerCount = 3; cokeCount=3; waterCount=3; friesCount=1; pizzaCount=0; lemonadeCount=0;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalCokePrice= cokeCount * cokePrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızatma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totallemonadePrice + "TL");
            Console.WriteLine();

            int totalPrice = totalCokePrice + totalFriesPrice + totalWaterPrice + totalHamburgerPrice + totallemonadePrice + totalPizzaPrice;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Toplam Tutar: " + totalPrice + "TL");

            #endregion

            Console.Read();
        }
    }
}




//Yazdırma Komutları