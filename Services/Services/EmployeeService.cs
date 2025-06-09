using Database.IRepositories;
using Database.Models;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IAbstractFactory _abstractFactory;

        public EmployeeService(IEmployeeRepository repository,IAbstractFactory abstractFactory)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
        }

        public async Task<bool> AddAsync(NhanVien entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(object id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeViewModel>> GetAllAsync()
        {
            var employees = await _repository.GetAllAsync();
            return employees.Select(pt => _abstractFactory.createEmployeeViewModel(pt)).ToList();
        }

        public async Task<NhanVien?> GetByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(NhanVien entity, string id)
        {
            return await _repository.UpdateAsync(entity,id);
        }
    }
}

