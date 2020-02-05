using System;
using Tabuleiros;
using Xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 2));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 6));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 7));

                Tela.ImprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
