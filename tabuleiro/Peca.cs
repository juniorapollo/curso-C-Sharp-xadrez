

namespace tabuleiro{

//Classe Genérica , Tabuleiro tem varias Pecas e a
//Peca tem varios tipos , REi , DAMA , PEAO
    class Peca {
        public Posicao posicao { get; set; } 
        public Tabuleiro tab { get; protected set;}
        public Cor cor { get ; protected set; }
        public int qtdMovimentos { get; protected set; } 

        public Peca(Tabuleiro tabuleiro , Cor cor){
            this.posicao = null;
            this.tab = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;

        }

    }
}