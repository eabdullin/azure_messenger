using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReactMessenger.Domain.Services
{
    interface IUserService
    {
        Task CreateUser(string userName);
    }
    
    interface IMessageService
    {
        Task AddMessage(string dialogId, string message);
    }
}
