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

        public Peca getPeca(Posicao pos)
        {
            return pecas[pos._linha, pos._coluna];
        }

        public bool existePeca(Posicao pos)
        {
            //primeiro validamos a posição, se for inválida corta o método aqui
            validarPosicao(pos);
            //testamos se existe alguma posição
            return getPeca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) {

            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            pecas[pos._linha, pos._coluna] = p;
            p._posicao = pos;
        }

        public bool posicaoValida(Posicao pos) {
            if (pos._coluna < 0 || pos._coluna >= _colunas || pos._linha < 0 || pos._linha >= _linhas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
