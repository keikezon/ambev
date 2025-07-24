namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct;

/// <summary>
/// Response model for GetProduct operation
/// </summary>
public class ListProductResult
{
    /// <summary>
    /// The unique identifier of the product
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The product's name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The product's price
    /// </summary>
    public decimal Price { get; set; }
}
