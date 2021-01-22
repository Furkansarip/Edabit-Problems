using System;

namespace TheCollatzConjecture
{

    class Program
    {
        public static int number = 0, Even = 0, Odd = 0;

        static void Main(string[] args)
        {//Sayı çift ise sayının yarısı yeni sayı olur.Sayı tek ise 3ile çarpıp 1 ekleriz.Sayı=1 olana kadar devam eder.
        Start: Console.Write("Please input positive number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                goto Start;
            }
            static void EvenorOdd(int number)
            {
                while (number >= 1)
                {
                    if (number <= 1)
                    {
                        Console.WriteLine("END");
                        break;
                    }
                    else if (number % 2 == 0)//Çift Kontrolü
                    {
                        Even = number / 2;
                        Console.Write(number + " is even - ");
                        Console.WriteLine(number + "/2=" + Even);
                        number = Even;//Yeni Sayı = Bölüm

                    }
                    else if (number % 2 != 0)//Çift değil ise
                    {
                        Odd = (number * 3) + 1;
                        Console.Write(number + " is odd - ");
                        Console.WriteLine(number + "x3+1=" + Odd);
                        number = Odd;//Yeni Sayı = 3n+1 
                    }
                }
            }
            EvenorOdd(number);
        }
    }
}
