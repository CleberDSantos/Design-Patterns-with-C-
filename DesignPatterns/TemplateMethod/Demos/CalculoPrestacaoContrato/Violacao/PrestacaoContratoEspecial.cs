namespace TemplateMethod.Demos.CalculoPrestacaoContrato.Violacao
{
    public class PrestacaoContratoEspecial
    {
        public decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            var valorPrincipal = valorTotal / numeroDeParcelas;

            var valorDaTaxaAdministrativa = (valorPrincipal * 0.01m) + 1.5m;

            var valorDoSeguro = 0.015m / valorPrincipal + 1;

            return valorPrincipal + valorDaTaxaAdministrativa + valorDoSeguro;
        }
    }
}