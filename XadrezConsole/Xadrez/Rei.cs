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
        public override string ToString()
        {
            return "R";
        }
    }
}
