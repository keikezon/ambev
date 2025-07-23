using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct;

/// <summary>
/// Validator for GetProductCommand
/// </summary>
public class ListProductValidator : AbstractValidator<ListProductCommand>
{
    /// <summary>
    /// Initializes validation rules for GetProductCommand
    /// </summary>
    public ListProductValidator()
    {

        RuleFor(x => x.Name)
            .MinimumLength(3)
            .WithMessage("Product name must be at least 3 characters long")
            .When(x => !string.IsNullOrEmpty(x.Name));
    }
}
