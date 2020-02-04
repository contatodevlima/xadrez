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
        public override string ToString()
        {
            return "T";
        }
    }
}
