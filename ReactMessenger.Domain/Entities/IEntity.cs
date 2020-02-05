using System;
using System.Collections.Generic;
using System.Text;

namespace ReactMessenger.Domain.Entities
{
    public interface IEntity
    {
        string Id { get; set; }
        DateTime CreatedDateUtc { get; set; }
    }
}
