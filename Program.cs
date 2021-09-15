using System;

namespace First_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if ( a == b)
            {
                Console.WriteLine("Числа равны");
            }
            else if ( a > b)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else{
                Console.WriteLine("Второе число больше первого");
            }*/

            //Задание 2
            /*int a = Convert.ToInt32(Console.ReadLine());
            if(a > 5 && a < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
               }*/

            //Задание 3
            /* int a = Convert.ToInt32(Console.ReadLine());
             if(a == 5 || a == 10)
             {
                 Console.WriteLine("Число либо равно 5, либо равно 10");
             }
             else
             {
                 Console.WriteLine("Неизвестное число");
             }*/

            //Задание 4
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 100) a += a * 0.05;
            else if (a >= 100 && a < 200) a += a * 0.07;
            else a += a * 0.1;
            Console.WriteLine(a);
        }
    }
}
