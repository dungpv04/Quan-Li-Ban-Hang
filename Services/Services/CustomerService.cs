using Database.IRepositories;
using Database.Models;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IAbstractFactory _abstractFactory;

        public CustomerService(ICustomerRepository repository, IAbstractFactory abstractFactory)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
        }

        public async Task<bool> AddIfNotExist(Khach entity)
        {
            return await _repository.AddIfNotExist(entity);
        }

        public async Task<bool> AddAsync(Khach entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(object id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CustomerViewModel>> GetAllAsync()
        {
            var customers = await _repository.GetAllAsync();
            return customers.Select(c => _abstractFactory.createCustomerViewModel(c)).ToList();
        }

        public Task<Khach?> GetByIdAsync(object id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<bool> UpdateAsync(Khach entity, string id)
        {
            return _repository.UpdateAsync(entity, id);
        }
    }
}