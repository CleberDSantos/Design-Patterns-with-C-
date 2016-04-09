using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Demos.CalculoPrestacaoContrato.Refatorada
{
     class PrestacaoContratoPadrao : Prestacao
    {
        protected override void CalcularValorDaTaxaAdministrativa()
        {
            ValorDaTaxaAdministrativa = ValorPrincipal * 0.01m;
        }

        protected override void CalcularValorDoSeguro()
        {
            ValorDoSeguro = ValorPrincipal * 0.015m;
        }
    }
}
