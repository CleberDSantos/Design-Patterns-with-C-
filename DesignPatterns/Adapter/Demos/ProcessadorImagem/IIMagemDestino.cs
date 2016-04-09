namespace Adapter.Demos.ProcessadorImagem
{
    public interface IIMagemDestino
    {
        void CarregarImagem(string nomeDoArquivo);

        void DesenharImagem(int posX, int posY, int largura, int altura);
    }
}