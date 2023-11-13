using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotel_api.Domain.Models;

namespace hotel_api.Infra.Repositories.Interfaces
{
    public interface IBaseRepository<T, K> where T : Base<K>
    {
        Task Add(T entity);
        Task Remove(K entityId);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(K entityId);
        Task Update (K entityId, T entity);
        Task Save();

    }
}