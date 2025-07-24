using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class UpdateSaleRequest
{
    /// <summary>
    /// The unique identifier of the sale to retrieve
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Set the sale's branch.
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Set the sale's status.
    /// Must not be null or empty and Unknown status.
    /// </summary>
    public SaleStatus Status { get; set; }

    /// <summary>
    /// Set the list of sale's items.
    /// </summary>
    public virtual ICollection<UpdateSaleItemRequest> SaleItems { get; set; } = new List<UpdateSaleItemRequest>();
}