namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação do item de uma venda no sistema.
    /// </summary>
    public interface ISaleItem
    {
        /// <summary>
        /// Obtém o identificador único do usuário.
        /// </summary>
        /// <returns>O ID do usuário como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o identificador único da venda.
        /// </summary>
        /// <returns>O ID da venda como uma string.</returns>
        public string SaleId { get; }

        /// <summary>
        /// Obtém o identificador único do produto.
        /// </summary>
        /// <returns>O ID do produto como uma string.</returns>
        public string ProductId { get; }

        /// <summary>
        /// Obtém a quantidade do produto.
        /// </summary>
        /// <returns>Quantidade do produto.</returns>
        public int Quantity { get; }

        /// <summary>
        /// Obtém o valor do produto x quantidade na venda.
        /// </summary>
        /// <returns>O valor do produto como um decimal.</returns>
        public decimal Amount { get; }

        /// <summary>
        /// Obtém o desconto do produto na venda.
        /// </summary>
        /// <returns>O desconto do produto como um decimal.</returns>
        public decimal Discount { get; }
    }
}
