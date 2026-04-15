using System;
using tabuleiro;
using xadrez;
using Xadrez;
using Xadrez.tabuleiro;

namespace Xadrez { 
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch(TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
