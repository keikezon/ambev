namespace Ambev.DeveloperEvaluation.Common.Security
{
    /// <summary>
    /// Define o contrato para representação de um produto no sistema.
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Obtém o identificador único do produto.
        /// </summary>
        /// <returns>O ID do produto como uma string.</returns>
        public string Id { get; }

        /// <summary>
        /// Obtém o nome do produto.
        /// </summary>
        /// <returns>O nome de usuário.</returns>
        public string Name { get; }

        /// <summary>
        /// Obtém o preço do produto no sistema.
        /// </summary>
        /// <returns>O valor do produto como um decimal.</returns>
        public decimal Price { get; }
    }
}
