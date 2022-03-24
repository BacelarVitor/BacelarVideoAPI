using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> AddAsync(T entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(T entity);
    }
}
