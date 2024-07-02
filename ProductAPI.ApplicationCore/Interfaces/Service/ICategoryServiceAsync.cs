using ProductAPI.ApplicationCore.Model.Request;
using ProductAPI.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.ApplicationCore.Interfaces.Service
{
    public interface ICategoryServiceAsync
    {
        Task<int> InsertCategory(CategoryRequestModel model);
        Task<int> UpdateCategory(CategoryRequestModel model, int id);
        Task<int> DeleteCategory(int id);
        Task<CategoryResponseModel> GetCategoryById(int id);
        Task<IEnumerable<CategoryResponseModel>> GetAllCategories();
    }
}
