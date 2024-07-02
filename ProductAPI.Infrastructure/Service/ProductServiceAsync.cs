using AutoMapper;
using ProductAPI.ApplicationCore.Interfaces.Repository;
using ProductAPI.ApplicationCore.Interfaces.Service;
using ProductAPI.ApplicationCore.Model.Request;
using ProductAPI.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Infrastructure.Service
{
    public class ProductServiceAsync : IProductServiceAsync
    {
        private readonly IProductRepositoryAsync productRepositoryAsync;
        private readonly IMapper mapper;

        public ProductServiceAsync(IProductRepositoryAsync productRepositoryAsync, IMapper mapper)
        {
            this.productRepositoryAsync = productRepositoryAsync;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ProductResponseModel>> GetAllProducts()
        {
           return  mapper.Map<IEnumerable<ProductResponseModel>>( await productRepositoryAsync.GetAllAsync());
        }

        public async Task<int> InsertProduct(ProductRequestModel model)
        {
            var result = mapper.Map<ApplicationCore.Entities.Product>(model);
            return await productRepositoryAsync.InsertAsync (result);
        }
    }
}
