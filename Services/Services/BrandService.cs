using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.IRepositories;
using Database.Models;
using Database.Repositories;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;

namespace Services.Services
{
    public class BrandService: IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IAbstractFactory _abstractFactory;
        public BrandService(IBrandRepository repository, IAbstractFactory abstractFactory)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
        }

        public async Task<bool> AddIfNotExist(ThuongHieu entity)
        {
            return await _repository.AddIfNotExist(entity);
        }

        public async Task<bool> AddAsync(ThuongHieu entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(object id)
        {
            return await _repository.DeleteAsync(id);
        }
     

        public Task<ThuongHieu?> GetByIdAsync(object id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<bool> UpdateAsync(ThuongHieu entity, string id)
        {
            return _repository.UpdateAsync(entity, id);
        }

        public async Task<IEnumerable<BrandViewModel>> GetAllAsync()
        {
            var brands = await _repository.GetAllAsync();
            return brands.Select(pt => _abstractFactory.createBrandViewModel(pt)).ToList();
        }
    }

}
