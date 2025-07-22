namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de uma venda no sistema.
    /// </summary>
    public interface ISale
    {
        /// <summary>
        /// Obtém o identificador único da venda.
        /// </summary>
        /// <returns>O ID da venda como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o identificador único do usuário.
        /// </summary>
        /// <returns>O Id de usuário.</returns>
        public Guid UserId { get; }

        /// <summary>
        /// Obtém o valor da venda no sistema.
        /// </summary>
        /// <returns>O valor da venda como uma decimal.</returns>
        public decimal Amount { get; }

        /// <summary>
        /// Obtém a filial da venda no sistema.
        /// </summary>
        /// <returns>A filial da venda como uma string.</returns>
        public string Branch { get; }

        /// <summary>
        /// Obtém o status da venda no sistema.
        /// </summary>
        /// <returns>O status da venda como um enum.</returns>
        public string Status { get; }
    }
}
