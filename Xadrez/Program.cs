using System;
using tabuleiro;
using xadrez;
using Xadrez;



namespace Xadrez { 
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a',1);
            Console.WriteLine(pos);

            Console.ReadLine();
            
        }
    }
}
