﻿using System;
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
    }
}
