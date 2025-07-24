using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct;


/// <summary>
/// Validator for CreateProductRequestValidator that defines validation rules for product creation.
/// </summary>
public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateProductRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - ID: Required
    /// - Name: Required, length between 3 and 50 characters
    /// - Price: Required, cannot be less than or equal to 0
    /// </remarks>
    public UpdateProductRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Product ID is required");
        RuleFor(product => product.Name).NotEmpty().Length(3, 50);
        RuleFor(product => product.Price).NotEmpty().GreaterThan(0);

    }
}
