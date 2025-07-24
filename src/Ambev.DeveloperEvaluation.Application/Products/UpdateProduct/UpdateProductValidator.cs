using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Validator for CreateProductCommand that defines validation rules for product creation command.
/// </summary>
public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductCommandValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ID: Required
    /// - Name: Required, must be between 3 and 50 characters
    /// - Price: Required
    /// </remarks>
    public UpdateProductCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Product ID is required");
        RuleFor(product => product.Name).NotEmpty().Length(3, 50);
        RuleFor(product => product.Price).NotEmpty().GreaterThan(0);
    }
}