using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {

        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tabuleiro);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);

            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("XEQUE!");
            }
        }

        private static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            imprimirConjuntoPecas(partida.getPecasCapturadas(Cor.Branca));

            Console.Write("Pretas: ");
            ConsoleColor corOriginal = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjuntoPecas(partida.getPecasCapturadas(Cor.Preta));
            Console.ForegroundColor = corOriginal;
        }

        private static void imprimirConjuntoPecas(HashSet<Peca> pecas)
        {
            Console.Write("[");

            foreach (Peca peca in pecas)
            {
                Console.Write(peca + " ");
            }

            Console.WriteLine("]");
        }

        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8-i + " ");

                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    imprimirPeca(tabuleiro.peca(i,j));
                }

                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");

                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }

                    imprimirPeca(tabuleiro.peca(i, j));

                    Console.BackgroundColor = fundoOriginal;
                }

                Console.WriteLine();
            }

            Console.BackgroundColor = fundoOriginal;

            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("-");
            }
            else if(peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            } else
            {
                ConsoleColor cor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write(peca);

                Console.ForegroundColor = cor;
            }

            Console.Write(" ");
        }

        public static PosicaoXadrez lerPosicaoXadez()
        {
            string posicao = Console.ReadLine();
            char coluna = posicao[0];
            int linha = int.Parse(posicao[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }
    }
}
