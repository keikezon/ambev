using FluentValidation;
namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleCommand that defines validation rules for sale creation command.
/// </summary>
public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Branch: Required, must be between 3 and 50 characters
    /// - SaleItems: Required, must be at least one sale item
    /// </remarks>
    public CreateSaleCommandValidator()
    {
        RuleFor(sale => sale.Branch).NotEmpty().Length(3, 50);
        RuleFor(sale => sale.SaleItems)
            .NotEmpty()
            .WithMessage("Sale items cannot be empty.")
            .Must(saleItems => saleItems.Count > 0)
            .WithMessage("At least one sale item is required.");
    }
}