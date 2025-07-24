using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;


/// <summary>
/// Validator for CreateSaleRequestValidator that defines validation rules for product creation.
/// </summary>
public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Branch: Required, length between 3 and 50 characters
    /// - SaleItems: Required, must be at least one sale item
    /// </remarks>
    public CreateSaleRequestValidator()
    {
        RuleFor(sale => sale.Branch).NotEmpty().Length(3, 50);
        RuleFor(sale => sale.SaleItems)
            .NotEmpty()
            .WithMessage("Sale items cannot be empty.")
            .Must(saleItems => saleItems.Count > 0)
            .WithMessage("At least one sale item is required.");

    }
}
