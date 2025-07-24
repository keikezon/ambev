namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;


/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class CreateSaleItemRequest
{
    /// <summary>
    /// Gets the product's id.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets the item quantity.
    /// </summary>
    public int Quantity { get; set; }
}
