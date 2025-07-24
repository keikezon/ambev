
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Handler for processing CreateSaleCommand requests
/// </summary>
public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreateSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for CreateSaleCommand</param>
    public UpdateSaleHandler(ISaleRepository saleRepository, IProductRepository productRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateSaleCommand request
    /// </summary>
    /// <param name="command">The CreateSale command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale details</returns>
    public async Task<UpdateSaleResult> Handle(UpdateSaleCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateSaleCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var sale = _mapper.Map<Sale>(command);

        foreach (var item in sale.SaleItems)
        {
            var product = await _productRepository.GetByIdAsync(item.ProductId, cancellationToken);
            if(product == null)
                throw new DomainException($"Product with ID {item.ProductId} not found.");
           CalculateTotalPrice(item, product.Price);
        }
        sale.Amount = sale.SaleItems.Sum(item => item.Amount);

        var createdSale = await _saleRepository.UpdateAsync(sale, cancellationToken);
        var result = _mapper.Map<UpdateSaleResult>(createdSale);
        return result;
    }

    public void CalculateTotalPrice(SaleItem saleItem, decimal unitPrice)
    {
        if (saleItem.Quantity > 20)
        {
            throw new DomainException("Cannot purchase more than 20 identical items.");
        }

        decimal discountPercentage = 0;

        if (saleItem.Quantity >= 10 && saleItem.Quantity <= 20)
        {
            discountPercentage = 0.20m; // 20% discount
        }
        else if (saleItem.Quantity >= 4 && saleItem.Quantity < 10)
        {
            discountPercentage = 0.10m; // 10% discount
        }

        decimal totalPrice = saleItem.Quantity * unitPrice;
        decimal discountAmount = totalPrice * discountPercentage;

        saleItem.Discount = discountAmount;
        saleItem.Amount = totalPrice - discountAmount;
    }
}
