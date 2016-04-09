namespace Strategy.Demos
{
    public class Pedido
    {
        private readonly ICalculadorFrete _calculadorDeFrete;

        /// <summary>
        // utilizando composição: o pedido mantém uma referência (passada em seu construtor)
        // para a Strategy base, normalmente uma interface ou classe abstrata
        /// </summary>
        /// <param name="calculadorDeFrete"></param>
        public Pedido(ICalculadorFrete calculadorDeFrete)
        {
            _calculadorDeFrete = calculadorDeFrete;
        }

        public decimal CalcularFrete()
        {
            // delegando o cálculo do frete para o objeto Strategy configurado
            return _calculadorDeFrete.CalcularFretePara(this);
        }
    }
}