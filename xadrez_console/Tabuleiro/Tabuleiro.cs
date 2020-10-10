using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int _linhas { get; set; }
        public int _colunas { get; set; }
        private Peca[,] pecas { get; set; }

        public Tabuleiro(int linhas, int colunas) {
            _linhas = linhas;
            _colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca getPeca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) {
            pecas[pos._linha, pos._coluna] = p;
            p._posicao = pos;
        }
    }
}
