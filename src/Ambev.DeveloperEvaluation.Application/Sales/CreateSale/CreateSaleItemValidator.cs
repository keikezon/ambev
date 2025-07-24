using FluentValidation;
namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleCommand that defines validation rules for sale creation command.
/// </summary>
public class CreateSaleItemCommandValidator : AbstractValidator<CreateSaleItemCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Branch: Required, must be between 3 and 50 characters
    /// </remarks>
    public CreateSaleItemCommandValidator()
    {
        RuleFor(sale => sale.Quantity).NotEmpty().GreaterThan(0);
    }
}