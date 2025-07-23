namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProduct;

/// <summary>
/// Request model for getting a product by name
/// </summary>
public class ListProductRequest
{
    /// <summary>
    /// The name of the product to retrieve
    /// </summary>
    public string Name { get; set; }
}
