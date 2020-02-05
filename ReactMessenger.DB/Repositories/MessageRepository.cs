using ReactMessenger.Domain;
using ReactMessenger.Domain.Entities;

namespace ReactMessenger.DB.Repositories
{
    public class MessageRepository : BaseRepository<Message>, IMessageRepository
    {
        public MessageRepository(MessengerContext messengerContext) : base(messengerContext)
        {
        }
    }
}
