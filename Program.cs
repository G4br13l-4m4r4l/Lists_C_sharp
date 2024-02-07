using System;
using System.Threading;
using System.Collections.Generic;
namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=======================================================\n _______  _______   _____   ______   _______  ______\r\n|       ||       | |  _  | |    _ | |       ||      |\r\n|  _____||_     _| | |_| | |   | || |___    ||  _    |\r\n| |_____   |   |  |   _   ||   |_||  ___|   || | |   |\r\n|_____  |  |   |  |  | |  ||    __ ||___    || |_|   |\r\n _____| |  |   |  |  |_|  ||   |  || ___|   ||       |\r\n|_______|  |___|  |_______||___|  |||_______||______|\n\n=======================================================\n");


            List<String> lista = new List<String>();

            Console.Write("\nHow many itens do you want to store? ");
            int quant = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quant; i++)
            {
                Console.Write("Type something to store: ");
                lista.Add(Console.ReadLine());
            }

            Console.WriteLine("\n===========================\n\tstoring\n===========================\n");

            for (int i = 0; i <= 100; i++) {
                Loading(i);
                Thread.Sleep(50);
            }
            Console.WriteLine("");
            foreach (String item in lista) {
                Console.WriteLine($"=> Stored: {item}");
            }
            Console.ReadKey();
        }

        static void Loading(int percentual)
        {
            int barra = Console.WindowWidth - 70;
            int quantChar = percentual == 0 ? 0 : (int)Math.Ceiling((percentual / 100.0) * barra);
            String progressBar = new String('=', quantChar);
            String spaces = new String(' ', barra - quantChar);

            Console.Write($"\r[{progressBar}{spaces}] {percentual}%");
        }
    }
}