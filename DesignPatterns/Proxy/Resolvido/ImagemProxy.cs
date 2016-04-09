namespace Proxy.Resolvido
{
    public class ImagemProxy : IImagem
    {
        private readonly string _nomeDoArquivo;

        private IImagem _imagem;

        public ImagemProxy(string nomeDoArquivo)
        {
            _nomeDoArquivo = nomeDoArquivo;
        }
        public void MostrarImagem()
        {
            if (_imagem == null)
                _imagem = new ImagemReal(_nomeDoArquivo);

            _imagem.MostrarImagem();
        }

    }
}
