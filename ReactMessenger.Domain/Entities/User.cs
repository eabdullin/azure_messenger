using System;
using System.Collections.Generic;
using System.Text;

namespace ReactMessenger.Domain.Entities
{
    public class User : IEntity
    {
        public DateTime CreatedDateUtc { get; set; }
        public string Id { get; set; }

        public IList<Message> InMessages { get; set; }
        public IList<Message> OutMessages { get; set; }
    }
}
