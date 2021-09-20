using System;

namespace First_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            /*
              Console.WriteLine("Введите первое число:");
             int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
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
            /*
              Console.WriteLine("Введите любое число:");
             int a = Convert.ToInt32(Console.ReadLine());
            if(a > 5 && a < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
               }*/

            //Задание 3
            /*
             Console.WriteLine("Введите любое число:");
             int a = Convert.ToInt32(Console.ReadLine());
             if(a == 5 || a == 10)
             {
                 Console.WriteLine("Число либо равно 5, либо равно 10");
             }
             else
             {
                 Console.WriteLine("Неизвестное число");
             }*/

            //Задание 4
            /*Console.WriteLine("Введите ваш вклад:");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 100) a += a * 0.05;
            else if (a >= 100 && a < 200) a += a * 0.07;
            else a += a * 0.1;
            Console.WriteLine(a);*/

            //Задание 5
            /*Console.WriteLine("Введите ваш вклад:");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 100) a += a * 0.05;
            else if (a >= 100 && a < 200) a += a * 0.07;
            else a += a * 0.1;
            Console.WriteLine(a + 15);*/

            //Задания 6 
            /*Console.WriteLine("Выберите операцию");
            Console.WriteLine("1-Сложение 2-Вычитание 3-Умножение");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a == 1) {Console.WriteLine("Сложение"); }
            else if(a == 2) { Console.WriteLine("Вычитание"); }
            else if(a == 3) { Console.WriteLine("Умножение"); }
            else { Console.WriteLine("Операция не определена"); }*/

            //Задание 7
            Console.WriteLine("Выберите операцию");
            Console.WriteLine("1-Сложение 2-Вычитание 3-Умножение");
            int opr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (opr == 1) { Console.WriteLine("Сложение"); Console.WriteLine(a + b); }
            else if (opr == 2) { Console.WriteLine("Вычитание"); Console.WriteLine(a - b); }
            else if (opr == 3) { Console.WriteLine("Умножение"); Console.WriteLine(a * b); } 
            else { Console.WriteLine("Операция не определена"); }
        }
    }
}
