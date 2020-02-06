
namespace Tabuleiros
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QuantMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();
        
        public void IncrementarQtnMovimentos()
        {
            QuantMovimentos++;
        }
    }
}
