using ReactMessenger.Domain;
using ReactMessenger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReactMessenger.DB
{
    public class BaseRepository<T> : IRepository<T> where T: class,  IEntity
    {
        private MessengerContext messengerContext;

        public BaseRepository(MessengerContext messengerContext)
        {
            this.messengerContext = messengerContext;
        }
        public async Task<long> Create(T o)
        {
            this.messengerContext.Set<T>().Add(o);
            await this.messengerContext.SaveChangesAsync();
            return o.Id;
        }

        public async Task Delete(long id)
        {
            var o = this.messengerContext.Set<T>().Find(id);
            this.messengerContext.Set<T>().Remove(o);
            await this.messengerContext.SaveChangesAsync();
        }

        public Task<T> Get(long id)
        {
            var o = this.messengerContext.Set<T>().Find(id);
            return Task.FromResult(o);
        }

        public async Task Update(long id, T o)
        {
            //var o = this.messengerContext.Set<T>().Find(id);
            this.messengerContext.Set<T>().Update(o);
            await this.messengerContext.SaveChangesAsync();
        }
    }
}
