using System;

namespace Console_welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*Console.WriteLine("Введите первую сторону прямоугольника:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр равен:" +  (a + b) * 2);*/

            //Задание 2
            /*Console.WriteLine("Введите первую сторону прямоугольника:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр равен:" + (a * b));*/

            //Задание 3
            /*Console.WriteLine("Введите ваш возраст:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a >= 18) { Console.WriteLine("Вы совершеннолетний"); }
            else { Console.WriteLine("Вы несовершеннолетний"); }*/

            //Задание 4
            /*Console.WriteLine("Вакцинированы ли вы?");
            Console.WriteLine("1 - да 2 -нет");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Есть и у вас билет?");
            Console.WriteLine("1 - да 2 -нет");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Имеются ли у вас острые-режущие предметы?");
            Console.WriteLine("1 - да 2 -нет");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a == 1 && b == 1 && c == 2)
            {Console.WriteLine("Вы допущены на самолёт");}
            else {Console.WriteLine("Вы не допущены"); }*/

            //Задание 5
            Console.WriteLine("Введите первую переменную:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную:");
            int b = Convert.ToInt32(Console.ReadLine());
            if( a == b)
            {
                a = 0;
                b = a;
                Console.WriteLine($"Первая переменная: {a} Вторая переменная: {b}");
            }
            else {
                a += b;
                b = a;
                Console.WriteLine($"Первая переменная: {a} Вторая переменная: {b}"); 
            }
            
        }
    }
}
