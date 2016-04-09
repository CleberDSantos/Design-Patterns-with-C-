using System;

namespace Adapter.Demos.ProcessadorImagem
{
    public class ImagemSurfaceSdl
    {

        public void CarregarSurface(string arquivo)
        {
            Console.WriteLine("Imagem " + arquivo + " carregada.");
        }

        public void DesenharSurface(int largura, int altura, int posicaoX, int posicaoY)
        {
            Console.WriteLine("SDL_Surface desenhada");
        }

    }
}