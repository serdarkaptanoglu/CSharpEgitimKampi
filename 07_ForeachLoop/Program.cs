﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu

            //Foreach(1;2;3;4)
            //1:Degişken türü
            //2:Degisken adı
            //3:In
            //4:Liste, koleksiyon, dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Ornek sinav sistemi uygulamasi

            Console.Write("***** C# Egitim kampi Uygulamasi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.Write("Sinifinizda kac ögrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            // öğrenci isimlerini ve not ortalamasını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                // her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
         for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi kaldı.");
                }
                Console.WriteLine("------------------------------");

            }

            #endregion

            Console.Read();
        }
    }
}
