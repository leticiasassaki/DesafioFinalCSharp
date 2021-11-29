using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Domain.OrderManagement.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }      

        public bool IsActive { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            IsActive = true;

        }
    }
}
