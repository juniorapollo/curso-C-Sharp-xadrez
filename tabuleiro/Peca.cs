

namespace tabuleiro{

    class Peca{
        public Posicao posicao { get; set; } 
        public Tabuleiro tab { get; protected set;}
        public Cor cor { get ; protected set; }
        public int qtdMovimentos { get; protected set; } 

        public Peca(Posicao posicao , Tabuleiro tabuleiro , Cor cor){
            this.posicao = posicao;
            this.tab = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;

        }

    }
}