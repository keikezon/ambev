using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct;

/// <summary>
/// Command for retrieving a product by their name
/// </summary>
public record ListProductCommand : IRequest<List<ListProductResult>?>
{
    /// <summary>
    /// The unique identifier of the product to retrieve
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of ListProductCommand
    /// </summary>
    /// <param name="id">The name of the product to retrieve</param>
    public ListProductCommand(string name)
    {
        Name = name;
    }
}
