using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int numero_2 = 5;
            ConsoleApp.WriteLine("Quanto é " + numero + " + " + numero_2 + " ?");

            int res = Convert.toInt32(ConsoleApp.ReadLine());

            if (res == 15)
            {
                ConsoleApp.WriteLine("Parabéns! Você acertou!");
            } else
            {
                ConsoleApp.WriteLine("Você errou, Tente Novamente: ");
            }
        }
    }
}