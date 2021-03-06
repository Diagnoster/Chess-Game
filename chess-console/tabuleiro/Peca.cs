
namespace tabuleiro {
    class Peca {

        public Posicao posicao { get; set; } // toda peça tem uma posição dentro do tabuleiro
        public Cor cor { get; protected set; }
        public int qntMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
        }

    }
}
