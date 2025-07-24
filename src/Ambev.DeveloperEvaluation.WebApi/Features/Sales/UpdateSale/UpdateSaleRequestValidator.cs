using Ambev.DeveloperEvaluation.Domain.Enums;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;


/// <summary>
/// Validator for CreateSaleRequestValidator that defines validation rules for product creation.
/// </summary>
public class UpdateSaleRequestValidator : AbstractValidator<UpdateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ID: Required
    /// - Branch: Required, length between 3 and 50 characters
    /// - Status: Required
    /// - SaleItems: Required, must be at least one sale item
    /// </remarks>
    public UpdateSaleRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Sale ID is required");
        RuleFor(sale => sale.Branch).NotEmpty().Length(3, 50);
        RuleFor(sale => sale.Status).NotEqual(SaleStatus.Unknown);
        RuleFor(sale => sale.SaleItems)
            .NotEmpty()
            .WithMessage("Sale items cannot be empty.")
            .Must(saleItems => saleItems.Count > 0)
            .WithMessage("At least one sale item is required.");

    }
}
