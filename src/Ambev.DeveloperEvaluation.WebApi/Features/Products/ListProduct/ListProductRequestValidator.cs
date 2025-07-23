using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProduct;

/// <summary>
/// Validator for GetProductRequest
/// </summary>
public class ListProductRequestValidator : AbstractValidator<ListProductRequest>
{
    /// <summary>
    /// Initializes validation rules for GetProductRequest
    /// </summary>
    public ListProductRequestValidator()
    {
        RuleFor(x => x.Name)
            .MinimumLength(3)
            .WithMessage("Product name must be at least 3 characters long")
            .When(x => !string.IsNullOrEmpty(x.Name));
    }
}
