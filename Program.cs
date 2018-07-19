using System;
using tabuleiro;
using xadrez;


namespace curso_C_Sharp_xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 4));
             tab.colocarPeca(new Dama(tab, Cor.Preta), new Posicao(1 , 5));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}