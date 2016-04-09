namespace Strategy.DesignPattern
{
    public class BoletoContext
    {
        private readonly IGeradorBoleto _geradorBoleto;

        public BoletoContext(IGeradorBoleto geradoBoletor)
        {
            _geradorBoleto = geradoBoletor;
        }

        public void GerarBoleto()
        {
            _geradorBoleto.Gerar();
        }

    }
}
