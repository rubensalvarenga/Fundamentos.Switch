using System;

namespace Fundamentos.Switch
{
    internal class Program
    {
        private const int V = 12;

        static void Main(string[] args)
        {
            Console.Clear();

            string valor = "andre";
            switch (valor)
            {
                case "joao": Console.WriteLine("não é o cara");break;
                case "Maria": Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("Não é tb"); break;
                case "andre": Console.BackgroundColor= ConsoleColor.Magenta; Console.WriteLine("Chegamos no cara"); break;
                default: Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("Chegamos ao final da lista");break;

            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");


            bool chave = false;
            switch (chave)
            {
                case true: Console.BackgroundColor = ConsoleColor.Magenta; Console.WriteLine("lâmpada ligada !"); break;
                case false: Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("lâmpada ligada !"); break;

            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");


            int saldo = 45;

            switch (saldo)
            {
                case 12: Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("saldo abaixo do esperado"); break;
                case 35: Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine("Não é o numero"); break;
                case 55: Console.BackgroundColor = ConsoleColor.Magenta; Console.WriteLine("Não é o numero, "); break;
                case 125: Console.BackgroundColor = ConsoleColor.Blue; Console.WriteLine("Seu saldo pode aplicar"); break;
                default : Console.BackgroundColor = ConsoleColor.Red;Console.WriteLine("Nenhuma valor foi acertado"); break;

            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
