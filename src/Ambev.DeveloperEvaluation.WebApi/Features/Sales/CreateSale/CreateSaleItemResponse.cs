using Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;


/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class CreateSaleItemResponse
{
    /// <summary>
    /// Gets the sale's id.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// Gets the product's id.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets the item quantity.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets the item's amount.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets the item's discount.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Gets the date and time when the item was added.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the item's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the product's information.
    /// </summary>
    public virtual GetProductResponse Product { get; set; } = new GetProductResponse();
}
