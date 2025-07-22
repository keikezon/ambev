using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a itens of a sale information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class SaleItem : BaseEntity, ISaleItem
{
    /// <summary>
    /// Gets the sale's id.
    /// Must not be null or empty.
    /// </summary>
    public Guid SaleId { get; set; }

    /// <summary>
    /// Gets the product's id.
    /// Must not be null or empty.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets the item quantity.
    /// Must not be null or empty.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets the item's amount.
    /// Must not be null or empty.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets the item's discount.
    /// Must not be null or empty.
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
    /// Gets the sale's information.
    /// </summary>
    public virtual Sale Sale { get; set; } = new Sale();

    /// <summary>
    /// Gets the product's information.
    /// </summary>
    public virtual Product Product { get; set; } = new Product();

    /// <summary>
    /// Gets the unique identifier of the saleItem.
    /// </summary>
    /// <returns>The saleItem's ID as a string.</returns>
    string ISaleItem.Id => Id.ToString();

    /// <summary>
    /// Gets the unique identifier of the sale.
    /// </summary>
    /// <returns>The sale's ID as a string.</returns>
    string ISaleItem.SaleId => SaleId.ToString();

    /// <summary>
    /// Gets the unique identifier of the product.
    /// </summary>
    /// <returns>The product's ID as a string.</returns>
    string ISaleItem.ProductId => ProductId.ToString();

    /// <summary>
    /// Gets the quantity.
    /// </summary>
    /// <returns>The quantity.</returns>
    int ISaleItem.Quantity => Quantity;

    /// <summary>
    /// Gets the saleItem's amount.
    /// </summary>
    /// <returns>The saleItem's amount as a decimal.</returns>
    decimal ISaleItem.Amount => Amount;

    /// <summary>
    /// Gets the saleItem's discount.
    /// </summary>
    /// <returns>The saleItem's discount as a decimal.</returns>
    decimal ISaleItem.Discount => Discount;

    /// <summary>
    /// Initializes a new instance of the SaleItem class.
    /// </summary>
    public SaleItem()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Performs validation of the saleItem entity using the SaleItemValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Quantity validity</list>
    /// 
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleItemValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}