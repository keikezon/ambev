using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a product in the system.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Product : BaseEntity, IProduct
{
    /// <summary>
    /// Gets the product's name.
    /// Must not be null or empty.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets the product's price.
    /// Must not be null or empty.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets the list of sale's items.
    /// </summary>
    public virtual ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();

    /// <summary>
    /// Gets the date and time when the product was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the product's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets the unique identifier of the product.
    /// </summary>
    /// <returns>The product's ID as a string.</returns>
    string IProduct.Id => Id.ToString();

    /// <summary>
    /// Gets the product name.
    /// </summary>
    /// <returns>The product name.</returns>
    string IProduct.Name => Name;

    /// <summary>
    /// Gets the product's price in the system.
    /// </summary>
    /// <returns>The product's price as a decimal.</returns>
    decimal IProduct.Price => Price;

    /// <summary>
    /// Initializes a new instance of the Product class.
    /// </summary>
    public Product()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Performs validation of the product entity using the ProductValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Name validity</list>
    /// 
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new ProductValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}