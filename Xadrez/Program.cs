using System;
using tabuleiro;
using xadrez;
using Xadrez;
using Xadrez.tabuleiro;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno: " + partida.turno);
                    Console.WriteLine("Aguardando a jogada da pessoa atual: " + partida.JogadorAtual);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao Origem = Tela.lerPosicaoXadrez().ToPosicao();

                    bool[,]posicaoPossiveis = partida.tab.peca(Origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab,posicaoPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao Destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.realizaJogada(Origem,Destino);

                }

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
