using System;

namespace Console_welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Приветствуем " + name);
        }
    }
}
