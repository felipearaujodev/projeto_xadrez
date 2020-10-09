using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao _posicao { get; set; }
        public Cor _cor { get; protected set; }
        public int _qtdMovimento { get; protected set; }
        public Tabuleiro _tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) {
            posicao = _posicao;
            tabuleiro = _tabuleiro;
            cor = _cor;
            _qtdMovimento = 0;
        }
    }
}
