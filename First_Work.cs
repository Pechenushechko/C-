using System;

namespace First_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /* int a = Convert.ToInt32( Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine((a + b)*2);*/

            //Задание 2
            /*int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);*/

            //Задание 3
            /*Console.WriteLine("Введите ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний");
            }
            else
            {
                Console.WriteLine("Вы не совершеннолетний");
            }*/

            //Задание 4
            /*Console.WriteLine("Вакцинированы ли вы?");
            Console.WriteLine("1- да, 2-нет");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("У вас есть билет?");
            Console.WriteLine("1- да, 2-нет");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Имеются ли у вас в наличии острые-режущие предметы?");
            Console.WriteLine("1- да, 2-нет");
            int c = Convert.ToInt32(Console.ReadLine());
            if( a == 1 && b == 1 && c == 2 ){
                Console.WriteLine("Вы можете сесть в самолёт");
            }
            else { Console.WriteLine("Вы не можете сесть в самолёт"); }*/

            //Задание 5
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a == b)
            {
                a += b;
                b = a;
            }
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a + "" + b);
        }
    }
}
