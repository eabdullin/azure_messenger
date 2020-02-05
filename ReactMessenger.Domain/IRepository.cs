using ReactMessenger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReactMessenger.Domain
{
    public interface IRepository<T> where T : IEntity
    {
        Task<long> Create(T o);
        Task<T> Get(long id);
        Task Update(long id, T o);
        Task Delete(long id);
    }
}
