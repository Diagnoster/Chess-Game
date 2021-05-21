using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Tabuleiro {
        // xadrez é 8x8
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; // matriz de peças

        public Tabuleiro (int linhas, int colunas) { 
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; // instancia matriz de peca e defini quantas linhas e colunas ele vai ter
        }

    }
}
