using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

        public EntityBase(TKey ıd, DateTimeOffset createdOn)
        {
            Id = ıd;
            CreatedOn = createdOn;
        }
    }
}
