
using tabuleiro;
using System;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimeTabuleiro(Tabuleiro tabuleiro)
        {
            for (int l = 0; l < tabuleiro._linhas; l++)
            {
                for (int c = 0; c < tabuleiro._colunas; c++)
                {
                    if (tabuleiro.getPeca(l, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.getPeca(l, c) + " ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
