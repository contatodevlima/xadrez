using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiros
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        public Peca Pecas(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }

        public Peca PecasP(Posicao pos)
        {
            return _pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Esta posição esta ocupada!");
            }
            _pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (PecasP(pos) == null)
            {
                return null;
            }
            Peca aux = PecasP(pos);
            aux.Posicao = null;
            _pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool ExistePeca(Posicao pos)
        {
            validarPosicao(pos);
            return PecasP(pos) != null;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }

    }
}
