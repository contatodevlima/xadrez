using System;
using Tabuleiros;
using Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 2));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
