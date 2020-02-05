using ReactMessenger.Domain;
using ReactMessenger.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactMessenger.DB.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MessengerContext messengerContext) : base(messengerContext)
        {
        }
    }
}
