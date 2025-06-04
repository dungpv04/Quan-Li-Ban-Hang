using Database.IRepositories;
using Database.Models;
using Database.Repositories;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductTypeService: IProductTypeService
    {
        private readonly IProductTypeRepository _repository;
        private readonly IAbstractFactory _abstractFactory;
        public ProductTypeService(IProductTypeRepository repository, IAbstractFactory abstractFactory)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
        }

        public async Task<bool> AddIfNotExist(LoaiHang entity)
        {
            return await _repository.AddIfNotExist(entity);
        }

        public async Task<bool> AddAsync(LoaiHang entity)
        {
            return await _repository.AddAsync(entity);
        }

        

        public async Task<bool> DeleteAsync(object id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductTypeViewModel>> GetAllAsync()
        {
            var productTypes = await _repository.GetAllAsync();
            return productTypes.Select(pt => _abstractFactory.createProductTypeViewModel(pt)).ToList();
        }

        public Task<LoaiHang?> GetByIdAsync(object id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<bool> UpdateAsync(LoaiHang entity, string id)
        {
            return _repository.UpdateAsync(entity, id);
        }
    }
}
