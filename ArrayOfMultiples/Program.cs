using System;

namespace ArrayOfMultiples
{
    class Program
    {
        public static int operation = 1, length = 100, num = 0;
       public static int[] numbers = new int[length];
        static void Main(string[] args)
        {//Length değerine göre girilen sayının katlarını alıp diziye aktarıyoruz.
            //Örnek : Girilen Sayı:12 Length:5 --> 12,24,36,48 ve 60 değerlerini ekranda görürüz.

            Console.Write("Number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Array Length:");
            length = Convert.ToInt32(Console.ReadLine());
            static void multiples(int num,int length) 
            {
                
                int multiply = 0;
                for(int i = 0; i < length; i++) 
                { 
                    multiply = num * operation++;
                    
                    numbers[i] = multiply;
                    Console.WriteLine(numbers[i]);
                }
                
               
            }
            multiples(num, length);
            


        }
    }
}
