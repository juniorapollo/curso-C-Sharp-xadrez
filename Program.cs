using System;
using tabuleiro;



namespace curso_C_Sharp_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);
            
            Console.ReadLine();
        }
    }
}

