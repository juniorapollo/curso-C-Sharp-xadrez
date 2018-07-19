using System;
using tabuleiro;

namespace curso_C_Sharp_xadrez{

    class Tela{
       
        public static void imprimirTabuleiro(Tabuleiro tab){

            for (int linha = 0; linha < tab.linhas; linha++){
                for (int col = 0; col < tab.colunas; col++){
                   if(tab.peca(linha,col) == null){
                        Console.Write(" - ");
                   }else{
                       Console.Write(tab.peca(linha,col));

                   }
                   
                }
                Console.WriteLine();
            }
        }

    }


}