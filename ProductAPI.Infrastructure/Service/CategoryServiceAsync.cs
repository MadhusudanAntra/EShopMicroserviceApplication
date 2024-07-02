using AutoMapper;
using ProductAPI.ApplicationCore.Entities;
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
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly ICategoryRepositoryAsync categoryRepositoryAsync;
        private readonly IMapper mapper;

        public CategoryServiceAsync(ICategoryRepositoryAsync categoryRepositoryAsync, IMapper mapper)
        {
            this.categoryRepositoryAsync = categoryRepositoryAsync;
            this.mapper = mapper;
        }
        public async Task<int> DeleteCategory(int id)
        {
            return await categoryRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryResponseModel>> GetAllCategories()
        {
            var result = await categoryRepositoryAsync.GetAllAsync();
            return mapper.Map<IEnumerable<CategoryResponseModel>>(result);
        }

        public async Task<CategoryResponseModel> GetCategoryById(int id)
        {
            var result = await categoryRepositoryAsync.GetById(id);
            return mapper.Map<CategoryResponseModel>(result);
        }

        public async Task<int> InsertCategory(CategoryRequestModel model)
        {
            var category = mapper.Map<Category>(model);
            return await categoryRepositoryAsync.InsertAsync(category);
        }

        public async Task<int> UpdateCategory(CategoryRequestModel model, int id)
        {
            var category = mapper.Map<Category>(model);
            category.Id = id;
            return await categoryRepositoryAsync.UpdateAsync(category);
        }
    }
}
