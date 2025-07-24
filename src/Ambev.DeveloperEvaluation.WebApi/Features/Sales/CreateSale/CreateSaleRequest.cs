namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class CreateSaleRequest
{
    /// <summary>
    /// Set the sale's branch.
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Set the list of sale's items.
    /// </summary>
    public virtual ICollection<CreateSaleItemRequest> SaleItems { get; set; } = new List<CreateSaleItemRequest>();
}