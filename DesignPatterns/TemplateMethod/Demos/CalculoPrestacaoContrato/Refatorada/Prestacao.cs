namespace TemplateMethod.Demos.CalculoPrestacaoContrato.Refatorada
{

    abstract class Prestacao
    {
        protected decimal ValorPrincipal;
        protected decimal ValorDaTaxaAdministrativa;
        protected decimal ValorDoSeguro;

        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            CalcularValorPrincipal(valorTotal, numeroDeParcelas);
            CalcularValorDaTaxaAdministrativa();
            CalcularValorDoSeguro();

            return CalcularValorTotal();
        }

        protected virtual void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
        {
            ValorPrincipal = valorTotal / numeroDeParcelas;
        }

        protected abstract void CalcularValorDaTaxaAdministrativa();
        protected abstract void CalcularValorDoSeguro();

        protected virtual decimal CalcularValorTotal()
        {
            return ValorPrincipal + ValorDaTaxaAdministrativa + ValorDoSeguro;
        }
    }

    //public class Prestacao
    //{
    //    private decimal _valorPrincipal;
    //    private decimal _valorDaTaxaAdministrativa;
    //    private decimal _valorDoSeguro;

    //    public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
    //    {
    //        CalcularValorPrincipal(valorTotal, numeroDeParcelas);
    //        CalcularValorDaTaxaAdministrativa();
    //        CalcularValorDoSeguro();
    //        return CalcularValorTotal();
    //    }

    //    private void CalcularValorPrincipal(decimal valorTotal, int numeroDeParcelas)
    //    {
    //        _valorPrincipal = valorTotal / numeroDeParcelas;
    //    }

    //    private void CalcularValorDaTaxaAdministrativa()
    //    {
    //        _valorDaTaxaAdministrativa = _valorPrincipal * 0.01m;
    //    }

    //    private void CalcularValorDoSeguro()
    //    {
    //        _valorDoSeguro = _valorPrincipal * 0.015m;
    //    }

    //    private decimal CalcularValorTotal()
    //    {
    //        return _valorPrincipal + _valorDaTaxaAdministrativa + _valorDoSeguro;
    //    }
    //}
}
