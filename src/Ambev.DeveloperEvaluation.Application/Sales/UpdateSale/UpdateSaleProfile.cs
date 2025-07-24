using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;


/// <summary>
/// Profile for mapping between Sale entity and CreateSaleResponse
/// </summary>
public class UpdateSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateSale operation
    /// </summary>
    public UpdateSaleProfile()
    {
        CreateMap<GetProductResult, Product>();
        CreateMap<UpdateSaleItemCommand, SaleItem>();
        CreateMap<UpdateSaleCommand, Sale>();
        CreateMap<SaleItem, UpdateSaleItemResult>();
        CreateMap<Sale, UpdateSaleResult>();
    }
}