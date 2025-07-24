using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.WebApi.Features.Users.GetUser;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;


/// <summary>
/// API response model for CreateSale operation
/// </summary>
public class UpdateSaleResponse
{
    /// <summary>
    /// The unique identifier of the created sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets the user's id.
    /// Must not be null or empty.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets the sale's amount.
    /// Must not be null or empty.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets the sale's branch.
    /// Must not be null or empty..
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Gets the sale's status.
    /// Must not be null or empty and Unknown status.
    /// </summary>
    public SaleStatus Status { get; set; }

    /// <summary>
    /// Gets the date and time when the user was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the sale's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the list of sale's items.
    /// </summary>
    public virtual ICollection<UpdateSaleItemResponse> SaleItems { get; set; } = new List<UpdateSaleItemResponse>();

    /// <summary>
    /// Gets the user information.
    /// </summary>
    public virtual GetUserResponse User { get; set; } = new GetUserResponse();
}
