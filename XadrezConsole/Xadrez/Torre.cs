using System;
using Tabuleiros;

namespace Xadrez
{
    class Torre : Peca
    {
        //public string Nome { get; set; }

        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
            Cor = cor;
            Tab = tab;
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.PecasP(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if(Tab.PecasP(pos) != null && Tab.PecasP(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha += 1;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PecasP(pos) != null && Tab.PecasP(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha -= 1;
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna +1);
            while (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PecasP(pos) != null && Tab.PecasP(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna += 1;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna -1);
            while (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.PecasP(pos) != null && Tab.PecasP(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna -= 1;
            }

            return mat;
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
