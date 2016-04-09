namespace TemplateMethod.Demos.CalculoPrestacaoContrato.Violacao
{
    public class Prestacao
    {
        public virtual decimal Calcular(decimal valorTotal, int numeroDeParcelas)
        {
            var valorPrincipal = valorTotal / numeroDeParcelas;

            var valorDaTaxaAdministrativa = valorPrincipal * 0.01m;

            var valorDoSeguro = valorPrincipal * 0.015m;

            return valorPrincipal + valorDaTaxaAdministrativa + valorDoSeguro;
        }
    }
}