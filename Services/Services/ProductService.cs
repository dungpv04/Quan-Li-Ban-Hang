using Database.IRepositories;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Services.IServices;
using Shared.IFactory;
using Shared.View_Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IProductTypeRepository _categoryRepository;
        private readonly AppDbContext _context; // Add context for direct database access
        private readonly IAbstractFactory _abstractFactory;

        public ProductService(IProductRepository repository, IAbstractFactory abstractFactory, AppDbContext context)
        {
            _repository = repository;
            _abstractFactory = abstractFactory;
            _context = context;
        }

        public async Task<bool> AddAsync(Hang entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(object id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync();
            return products.Select(p => _abstractFactory.createProductViewModel(p)).ToList();
        }

        public async Task<Hang?> GetByIdAsync(object id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Hang entity, string id)
        {
            return await _repository.UpdateAsync(entity, id);
        }
        
        // Implementation for new methods
        public async Task<IEnumerable<LoaiHang>> GetAllCategoriesAsync()
        {
            return await _context.LoaiHangs.ToListAsync();
        }

        public async Task<IEnumerable<ThuongHieu>> GetAllBrandsAsync()
        {
            return await _context.ThuongHieus.ToListAsync();
        }

        public async Task<IEnumerable<NhaCungCap>> GetAllSuppliersAsync()
        {
            return await _context.NhaCungCaps.ToListAsync();
        }
    }
}