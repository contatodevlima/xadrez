using System;
using Tabuleiros;

namespace Xadrez
{
    class Rei : Peca
    {
        //public string Nome { get; set; }

        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
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
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //ne
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //se
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //so
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //se
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
