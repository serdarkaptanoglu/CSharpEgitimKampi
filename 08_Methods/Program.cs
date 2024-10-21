using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();




            #endregion

            #region Geriye deger dondurmeyen string parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Serdar Kaptanoglu");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Musteri: " + name + " " +  surName);
            //}
            //CustomerCard("Serdar", "Kaptanoglu");
            //CustomerCard("Ali", "Kaya");

            #endregion

            #region Geriye deger dondurmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye deger donduren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye deger donduren string parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ulke: " + countryName + "  -  Baskent: " + capital + "  -  Bayrak: " + flagColor;
            //    return cardInfo;
            //}
            ////Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı/Beyaz"));
            //string cn, cp, fc;
            //Console.Write("Ülke Adını Giriniz: ");
            //cn = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //cp = Console.ReadLine();
            //Console.Write("Bayrak Rengi Giriniz: ");
            //fc = Console.ReadLine();

            //Console.WriteLine(CountryCard(cn, cp, fc));

            #endregion

            #region Geriye deger donduren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(61, 28));
            //Console.WriteLine(Sum(100, 5462));
            //Console.WriteLine(Sum(145, 2));



            #endregion

            #region Ornek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                double result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return $"{student} {result} alarak Sınavı geçti";
                }
                else
                {
                    return $"{student} {result} Başarısız Oldu";
                }
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.WriteLine(ExamResult("Ahmet", 25, 23, 43));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
