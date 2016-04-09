namespace Strategy.Violacao
{
    public class GeradorBoleto
    {

        /// <summary>
        /// Codigo responsavel por gerar boletos
        /// </summary>
        /// <param name="banco">Banco necessario para gerar o boleto</param>
        /// <returns>Codigo de barras gerado</returns>
        public string GerarBoleto(string banco)
        {
            var codigo = string.Empty;

            if (banco == "ITAU")
            {
                codigo = this.GerarBoletoItau();

            }
            else if (banco == "Brasil")
            {
                codigo = this.GerarBoletoBancoBrasil();

            }
            else if (banco == "Bradesco")
            {
                codigo = this.GerarBancoBradesco();
            }

            return codigo;
        }

        /// <summary>
        /// metodo responsavel pela geracao do codigo de barras do Banco Itau
        /// </summary>
        /// <returns>codigo de barras gerado</returns>
        public virtual string GerarBoletoItau()
        {
            return string.Empty;
        }

        /// <summary>
        /// metodo responsavel pela geracao do codigo de barras do Banco do Brasil
        /// </summary>
        /// <returns>codigo de barras gerado</returns>
        public virtual string GerarBoletoBancoBrasil()
        {
            return string.Empty;
        }


        /// <summary>
        /// metodo responsavel pela geracao do codigo de barras do Banco Bradesco
        /// </summary>
        /// <returns>codigo de barras gerado</returns>
        public virtual string GerarBancoBradesco()
        {
            return string.Empty;
        }

    }
}
