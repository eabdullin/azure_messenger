using System;
using System.Collections.Generic;

namespace ReactMessenger.Domain.Entities
{
    public class Message : IEntity
    {
        public DateTime CreatedDateUtc { get; set; }
        public string Id { get; set; }

        public long FromId { get; set; }
    }

    public class Dialog: IEntity
    {
        public string Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }

        public IList<User> Participants { get; set; }
    }
}
