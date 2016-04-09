using System;

namespace Adapter.Demos.ProcessadorImagem
{
    public class ImagemOpenGlAdapter : ImagemOpenGl, IIMagemDestino
    {
        public void CarregarImagem(string nomeDoArquivo)
        {
            throw new NotImplementedException();
        }

        public void DesenharImagem(int posX, int posY, int largura, int altura)
        {
            throw new NotImplementedException();
        }
    }
}