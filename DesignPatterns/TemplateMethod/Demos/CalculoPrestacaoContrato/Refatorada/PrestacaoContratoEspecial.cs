namespace TemplateMethod.Demos.CalculoPrestacaoContrato.Refatorada
{
    class PrestacaoContratoEspecial : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            ValorDaTaxaAdministrativa = (ValorPrincipal * 0.01m) + 1.5m;
        }

        protected override void CalcularValorDoSeguro()
        {
            ValorDoSeguro = 0.015m / ValorPrincipal + 1;
        }
    }
}
