using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProduct;

/// <summary>
/// Handler for processing GetProductCommand requests
/// </summary>
public class ListProductHandler : IRequestHandler<ListProductCommand, List<ListProductResult>?>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetProductHandler
    /// </summary>
    /// <param name="productRepository">The product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for GetProductCommand</param>
    public ListProductHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ListProductCommand request
    /// </summary>
    /// <param name="request">The GetProduct command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The product list if found</returns>
    public async Task<List<ListProductResult>?> Handle(ListProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.ListAsync(request.Name, cancellationToken);
        if (product == null)
            throw new KeyNotFoundException($"Products not found");

        return _mapper.Map<List<ListProductResult>?>(product);
    }
}
