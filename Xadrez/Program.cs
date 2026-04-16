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
                    Console.Write("Origem:");
                    Posicao Origem = Tela.lerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino:");
                    Posicao Destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.executaMovimento(Origem, Destino);

                }

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
