using FluentValidation;
namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Validator for UpdateSaleCommand that defines validation rules for sale creation command.
/// </summary>
public class UpdateSaleItemCommandValidator : AbstractValidator<UpdateSaleItemCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Branch: Required, must be between 3 and 50 characters
    /// </remarks>
    public UpdateSaleItemCommandValidator()
    {
        RuleFor(sale => sale.Quantity).NotEmpty().GreaterThan(0);
    }
}