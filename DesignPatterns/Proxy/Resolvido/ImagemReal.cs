using System;

namespace Proxy.Resolvido
{
    public class ImagemReal : IImagem
    {
        private readonly string _nomeDoArquivo;

        public ImagemReal(string nomeDoArquivo)
        {
            this._nomeDoArquivo = nomeDoArquivo;
            CarregarImagemDoDisco();
        }

        private void CarregarImagemDoDisco()
        {
            Console.WriteLine("Carregando " + _nomeDoArquivo);
        }

        public void MostrarImagem()
        {
            Console.WriteLine("Mostrando " + _nomeDoArquivo);
        }
    }
}
