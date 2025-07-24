namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;


/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class UpdateSaleItemRequest
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
