using System;
using tabuleiro;



namespace curso_C_Sharp_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

            p = new Posicao(1,2);

            Console.WriteLine("Posicao " +p);
            Console.ReadLine();
        }
    }
}

