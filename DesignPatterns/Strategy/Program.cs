using Strategy.DesignPattern;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var boletoContext = new BoletoContext(new BancoBrasilBoleto());

            boletoContext.GerarBoleto();


            boletoContext = new BoletoContext(new ItauBoleto());

            boletoContext.GerarBoleto();

        }
    }
}
