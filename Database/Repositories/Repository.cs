using Database.IRepositories;
using Database.Models;
using Logger.ConsoleLogger;
using Logger.Decorator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Database.Repositories
{
    public class Repository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;
        protected readonly IConsoleLogger _logger;
        protected readonly FileLoggerDecorator _fileLogger;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _logger = ConsoleLogger.Instance;
            _fileLogger = new FileLoggerDecorator(_logger);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var entities = await _dbSet.ToListAsync();
                _fileLogger.LogInfo($"Successfully fetched all entities of type {typeof(T).Name}. Count: {entities.Count}");
                if (entities.Count == 0)
                    _fileLogger.LogWarning($"No entities found of type {typeof(T).Name}.");
                else
                    _fileLogger.LogDebug($"Fetched {entities.Count} entities of type {typeof(T).Name}.");
                return entities;
            }
            catch (Exception ex)
            {
                _fileLogger.LogError($"Error fetching all entities of type {typeof(T).Name}: {ex.Message}");
                throw;
            }
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity != null)
                    _fileLogger.LogInfo($"Successfully fetched entity of type {typeof(T).Name} with id={id}.");
                else
                    _fileLogger.LogWarning($"No entity found of type {typeof(T).Name} with id={id}.");
                return entity;
            }
            catch (Exception ex)
            {
                _fileLogger.LogError($"Error fetching entity of type {typeof(T).Name} with id={id}: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                _fileLogger.LogInfo($"Added new entity of type {typeof(T).Name}.");
                return true;
            }
            catch (Exception ex)
            {
                _fileLogger.LogError($"Error adding entity of type {typeof(T).Name}: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                _fileLogger.LogInfo($"Updated entity of type {typeof(T).Name}.");
                return true;
            }
            catch (Exception ex)
            {
                _fileLogger.LogError($"Error updating entity of type {typeof(T).Name}: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteAsync(object id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    await _context.SaveChangesAsync();
                    _fileLogger.LogInfo($"Deleted entity of type {typeof(T).Name} with id={id}.");
                    return true;
                }
                else
                {
                    _fileLogger.LogWarning($"No entity found to delete of type {typeof(T).Name} with id={id}.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _fileLogger.LogError($"Error deleting entity of type {typeof(T).Name} with id={id}: {ex.Message}");
                return false;
            }
        }

    }
}