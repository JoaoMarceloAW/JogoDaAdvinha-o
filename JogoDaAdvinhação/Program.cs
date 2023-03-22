using System.ComponentModel.Design;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace JogoDaAdvinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random numaleatrio = new Random();
            int numeroaleatrio = numaleatrio.Next(1, 21);
            int totaltentavias = 0;
            int numerochute = 0;
            double totaldepontos = 1000;
            


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Seja muito bem vindo ao jogo da advinhação! ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Digite a dificuldade que você deseja: ");
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
            Console.WriteLine("Escolha: ");
            int dificuldade = Convert.ToInt32(Console.ReadLine());
            
            switch (dificuldade)
            {
                case 1: totaltentavias = 15; break;

                case 2: totaltentavias = 10; break;

                case 3: totaltentavias = 5; break;


                    
            }

            for (int numerodechutes = 1; numerodechutes <= totaltentavias; numerodechutes++)
            {
                Console.Clear();

                Console.WriteLine($"Você ainda tem {numerodechutes} tentativas de {totaltentavias}");

                Console.WriteLine("Digite o numero secreto: ");
                 numerochute = Convert.ToInt32(Console.ReadLine());

                if (numerochute == numeroaleatrio)
                {
                    Console.WriteLine("Parabéns você acertou!!!");
                    Console.WriteLine($"Você fez {totaldepontos} pontos!!!");
                    break;

                }
                else if (numerochute < numeroaleatrio)
                {
                    Console.WriteLine("O seu numero é menor que o numero secreto");
                }

                else
                {
                    Console.WriteLine("O seu numero é maior que o numero secreto");
                    double pontosperdidos =  Math.Abs((numerochute - numeroaleatrio) / 2);
                    totaldepontos -= pontosperdidos;
                    Console.WriteLine($"Você fez {totaldepontos} pontos!!!");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();

           

            Console.ReadLine();
        }
    }
}