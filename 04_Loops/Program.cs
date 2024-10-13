using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Dongusu

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Egitim Kampi");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lutfen ekrana yazilmasi istediginiz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yasasin Cumhuriyet");
            //}

            #endregion

            #region For Dongusu ile Karar Yapilari

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i %5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int result = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        result += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(result);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium*=2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}
            //Console.WriteLine(bacterium);

            #endregion

            #region While Dongusu

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Donguler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Ornek Sinav Sorusu

            //Console.Write("3 basamakli bir sayi giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //sum = ones + tens + hundreds;
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
