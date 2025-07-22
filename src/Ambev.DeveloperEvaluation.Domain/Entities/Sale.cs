using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a sale in the system with sale itens informations.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity, ISale
{
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
    public string Branch { get; set; } = string.Empty ;

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
    public virtual ICollection<SaleItem> SaleItems { get; set; } = new List<SaleItem>();

    /// <summary>
    /// Gets the user information.
    /// </summary>
    public virtual User User { get; set; } = new User();

    /// <summary>
    /// Gets the unique identifier of the sale.
    /// </summary>
    /// <returns>The sale's ID as a string.</returns>
    string ISale.Id => Id.ToString();

    /// <summary>
    /// Gets the unique identifier of the user.
    /// </summary>
    /// <returns>The user's ID as a string.</returns>
    Guid ISale.UserId => UserId;

    /// <summary>
    /// Gets the sale's amount.
    /// </summary>
    /// <returns>The sale's amount as a decimal.</returns>
    decimal ISale.Amount => Amount;

    /// <summary>
    /// Gets the sale's branch.
    /// </summary>
    /// <returns>The sale's branch as a string.</returns>
    string ISale.Branch => Branch;

    /// <summary>
    /// Gets the sale's status.
    /// </summary>
    /// <returns>The sale's status as a string.</returns>
    string ISale.Status => Status.ToString();

    /// <summary>
    /// Initializes a new instance of the Sale class.
    /// </summary>
    public Sale()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Performs validation of the sale entity using the SaleValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Status validity</list>
    /// 
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new SaleValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }

    /// <summary>
    /// Processing the user sale.
    /// Changes the sale's status to Processing.
    /// </summary>
    public void Processing()
    {
        Status = SaleStatus.Processing;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Cancelled the user sale.
    /// Changes the sale's status to Cancelled.
    /// </summary>
    public void Cancelled()
    {
        Status = SaleStatus.Cancelled;
        UpdatedAt = DateTime.UtcNow;
    }
}