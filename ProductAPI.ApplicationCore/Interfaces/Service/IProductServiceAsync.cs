using ProductAPI.ApplicationCore.Model.Request;
using ProductAPI.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.ApplicationCore.Interfaces.Service
{
    public interface IProductServiceAsync
    {
        Task<int> InsertProduct(ProductRequestModel model);
        Task<IEnumerable<ProductResponseModel>> GetAllProducts();
    }
}
