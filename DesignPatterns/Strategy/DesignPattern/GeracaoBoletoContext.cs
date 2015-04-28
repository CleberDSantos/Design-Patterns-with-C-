
namespace Strategy.DesignPattern
{
     public class GeracaoBoletoContext
    {
         private readonly IGeracaoBoletoStrategy _geracaoBoleto;

         public GeracaoBoletoContext(IGeracaoBoletoStrategy strategy)
         {
             this._geracaoBoleto = strategy;
         }

         public string GerarBoleto()
         {
             return this._geracaoBoleto.Gerar();
         }
    }
}
