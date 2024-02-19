using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            int i = 0;
            int j = 0;
            int jogada = 0;
            Console.WriteLine("Bem vindo ao jogo da velha");
            string[,] JogoDaVelha =
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(JogoDaVelha[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("jogar 1 (x) começa");
            for (int m = 0; m <= 4; m++)
            {
                jogada = int.Parse(Console.ReadLine());
                vezx(ref JogoDaVelha, jogada);
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(JogoDaVelha[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Vez do jogador 2 (0)");
                jogada = int.Parse(Console.ReadLine());
                vezo(ref JogoDaVelha, jogada);
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(JogoDaVelha[i, j] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Vez do jogador 1 (x)");
            }
            Console.WriteLine("Empate !!!!");
            Console.ReadKey();
        }
        public static string[,] vezx(ref string[,] JogoDaVelha, int jogada)
        {
            if (jogada == 1 && JogoDaVelha[0, 0] != "o")
            {
                JogoDaVelha[0, 0] = ("x");
            }
            if (jogada == 2 && JogoDaVelha[0, 1] != "o")
            {
                JogoDaVelha[0, 1] = ("x");
            }
            if (jogada == 3 && JogoDaVelha[0, 2] != "o")
            {
                JogoDaVelha[0, 2] = ("x");
            }
            if (jogada == 4 && JogoDaVelha[1, 0] != "o")
            {
                JogoDaVelha[1, 0] = ("x");
            }
            if (jogada == 5 && JogoDaVelha[1, 1] != "o")
            {
                JogoDaVelha[1, 1] = ("x");
            }
            if (jogada == 6 && JogoDaVelha[1, 2] != "o")
            {
                JogoDaVelha[1, 2] = ("x");
            }
            if (jogada == 7 && JogoDaVelha[2, 0] != "o")
            {
                JogoDaVelha[2, 0] = ("x");
            }
            if (jogada == 8 && JogoDaVelha[2, 1] != "o")
            {
                JogoDaVelha[2, 1] = ("x");
            }
            if (jogada == 9 && JogoDaVelha[2, 2] != "o")
            {
                JogoDaVelha[2, 2] = ("x");
            }
            FimDoJogo(ref JogoDaVelha);
            Console.Clear();
            return JogoDaVelha;
        }
        public static void FimDoJogo(ref string[,] JogoDaVelha)
        {
            if (JogoDaVelha[0, 0] == "x" && JogoDaVelha[0, 1] == "x" && JogoDaVelha[0, 2] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[1, 0] == "x" && JogoDaVelha[1, 1] == "x" && JogoDaVelha[1, 2] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[2, 0] == "x" && JogoDaVelha[2, 1] == "x" && JogoDaVelha[2, 2] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[0, 0] == "x" && JogoDaVelha[1, 0] == "x" && JogoDaVelha[2, 0] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[0, 1] == "x" && JogoDaVelha[1, 1] == "x" && JogoDaVelha[2, 1] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[0, 2] == "x" && JogoDaVelha[1, 2] == "x" && JogoDaVelha[2, 2] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[0, 0] == "x" && JogoDaVelha[1, 1] == "x" && JogoDaVelha[2, 2] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[0, 2] == "x" && JogoDaVelha[1, 1] == "x" && JogoDaVelha[2, 0] == "x")
            {
                Confx();
            }
            if (JogoDaVelha[0, 0] == "o" && JogoDaVelha[0, 1] == "o" && JogoDaVelha[0, 2] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[1, 0] == "o" && JogoDaVelha[1, 1] == "o" && JogoDaVelha[1, 2] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[2, 0] == "o" && JogoDaVelha[2, 1] == "o" && JogoDaVelha[2, 2] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[0, 0] == "o" && JogoDaVelha[1, 0] == "o" && JogoDaVelha[2, 0] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[0, 1] == "o" && JogoDaVelha[1, 1] == "o" && JogoDaVelha[2, 1] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[0, 2] == "o" && JogoDaVelha[1, 2] == "o" && JogoDaVelha[2, 2] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[0, 0] == "o" && JogoDaVelha[1, 1] == "o" && JogoDaVelha[2, 2] == "o")
            {
                Confo();
            }
            if (JogoDaVelha[0, 2] == "o" && JogoDaVelha[1, 1] == "o" && JogoDaVelha[2, 0] == "o")
            {
                Confo();
            }

        }
        public static string[,] vezo(ref string[,] JogoDaVelha, int jogada)
        {
            if (jogada == 1 && JogoDaVelha[0, 0] != "x")
            {
                JogoDaVelha[0, 0] = ("o");
            }
            if (jogada == 2 && JogoDaVelha[0, 1] != "x")
            {
                JogoDaVelha[0, 1] = ("o");
            }
            if (jogada == 3 && JogoDaVelha[2, 0] != "x")
            {
                JogoDaVelha[0, 2] = ("o");
            }
            if (jogada == 4 && JogoDaVelha[1, 0] != "x")
            {
                JogoDaVelha[1, 0] = ("o");
            }
            if (jogada == 5 && JogoDaVelha[1, 1] != "x")
            {
                JogoDaVelha[1, 1] = ("o");
            }
            if (jogada == 6 && JogoDaVelha[1, 2] != "x")
            {
                JogoDaVelha[1, 2] = ("o");
            }
            if (jogada == 7 && JogoDaVelha[2, 0] != "x")
            {
                JogoDaVelha[2, 0] = ("o");
            }
            if (jogada == 8 && JogoDaVelha[2, 1] != "x")
            {
                JogoDaVelha[2, 1] = ("o");
            }
            if (jogada == 9 && JogoDaVelha[2, 2] != "x")
            {
                JogoDaVelha[2, 2] = ("o");
            }
            FimDoJogo(ref JogoDaVelha);
            Console.Clear();
            return JogoDaVelha;
        }
        public static void Confx()
        {
            Console.Clear();
            Console.WriteLine("Vencedor Jogador 1 (x)");
            Console.WriteLine("Quer jogar novamente? y/n");
            String jogarnovamente = Console.ReadLine();
            if (jogarnovamente == "y")
            {
                Console.Clear();
                Run();
            }
            if (jogarnovamente == "n")
            {
                Environment.Exit(0);
            }

        }
        public static void Confo()
        {
            Console.Clear();
            Console.WriteLine("Vencedor Jogador 1 (o)");
            Console.WriteLine("Quer jogar novamente? y/n");
            String jogarnovamente = Console.ReadLine();
            if (jogarnovamente == "y")
            {
                Console.Clear();
                Run();
            }
            if (jogarnovamente == "n")
            {
                Environment.Exit(0);
            }
        }
    }

}
