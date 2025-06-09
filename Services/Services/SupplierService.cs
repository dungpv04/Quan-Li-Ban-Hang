using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.IRepositories;
using Database.Models;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;

namespace Services.Services
{
    public class SupplierService: ISupplierService
    {
        private readonly ISupplierRepository _repository;
        private readonly IAbstractFactory _abstractFactory;

        public SupplierService(ISupplierRepository repository, IAbstractFactory abstractFactory)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
        }

        public async Task<bool> AddIfNotExist(NhaCungCap entity)
        {
            return await _repository.AddIfNotExist(entity);
        }

        public async Task<bool> AddAsync(NhaCungCap entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(object id)
        {
            return await _repository.DeleteAsync(id);
        }


        public Task<NhaCungCap?> GetByIdAsync(object id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<bool> UpdateAsync(NhaCungCap entity, string id)
        {
            return _repository.UpdateAsync(entity, id);
        }

        public async Task<IEnumerable<SupplierViewModel>> GetAllAsync()
        {
            var suppliers = await _repository.GetAllAsync();
            return suppliers.Select(pt => _abstractFactory.createSupplierViewModel(pt)).ToList();
        }
    }
}
