using System;

namespace CS8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            int numberRepetitions;
            Console.Write("Введите сообщение: ");
            message = Console.ReadLine();
            Console.Write("Введите количество повторов сообщения: ");
            numberRepetitions = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < numberRepetitions; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
