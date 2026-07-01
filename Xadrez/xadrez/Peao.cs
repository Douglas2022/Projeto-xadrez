using tabuleiro;

namespace Xadrez.xadrez
{
    internal class Peao : Peca
    {
        public Peao(Tabuleiro tab,Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "P";
        }
        private bool existeInimigo(Posicao pos)
        {
            Peca P = tab.peca(pos);
            return P != null && P.cor != cor;
        }
        private bool livre(Posicao pos)
        {
            return tab.peca(pos) == null;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            {
                Posicao pos = new Posicao(0,0);
            }
        }
}
