using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("##### Configurando subsistemas #####");

            var audio = new SistemaDeAudio();

            audio.ConfigurarCanais();
            audio.ConfigurarFrequencia();
            audio.ConfigurarVolume();


            var input = new SistemaDeInput();

            input.ConfigurarTeclado();
            input.ConfigurarJoystick();

            var video = new SistemaDeVideo();

            video.ConfigurarCores();
            video.ConfigurarResolucao();

            Console.Write("##### Utilizando subsistemas #####");

            audio.ReproduzirAudio("teste.mp3");

        }
    }

    public class SistemaDeVideo
    {
        public virtual void ConfigurarCores()
        {
            throw new NotImplementedException();
        }

        public virtual void ConfigurarResolucao()
        {
            throw new NotImplementedException();
        }

        public virtual void RenderizarImagem(string imagem)
        {
            throw new NotImplementedException();
        }
    }

    public class SistemaDeInput
    {
        public virtual void ConfigurarTeclado()
        {
            throw new NotImplementedException();
        }

        public virtual void ConfigurarJoystick()
        {
            throw new NotImplementedException();
        }

        public virtual void LerInput()
        {
            throw new NotImplementedException();
        }
    }

    public class SistemaDeAudio
    {

        public virtual void ConfigurarFrequencia()
        {
            Console.Write("Frequencia configurada");
        }

        public virtual void ConfigurarVolume()
        {
            Console.Write("Volume configurado");
        }

        public virtual void ConfigurarCanais()
        {
            Console.Write("Canais configurados");
        }

        public virtual void ReproduzirAudio(string arquivo)
        {
            Console.Write("Reproduzindo: " + arquivo);
        }
    }

    public class SistemasFacade
    {
        public SistemaDeAudio Audio { get; set; }
        public SistemaDeInput Input { get; set; }
        public SistemaDeVideo Video { get; set; }

        public void InicializarSubsistemas()
        {
            Video = new SistemaDeVideo();
            Video.ConfigurarCores();
            Video.ConfigurarResolucao();

            Input = new SistemaDeInput();
            Input.ConfigurarJoystick();
            Input.ConfigurarTeclado();

            Audio = new SistemaDeAudio();
            Audio.ConfigurarCanais();
            Audio.ConfigurarFrequencia();
            Audio.ConfigurarVolume();
        }

        public void ReproduzirAudio(String arquivo)
        {
            Audio.ReproduzirAudio(arquivo);
        }

        public void RenderizarImagem(String imagem)
        {
            Video.RenderizarImagem(imagem);
        }

        public void LerInput()
        {
            Input.LerInput();
        }

    }

}
