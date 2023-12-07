using System;

namespace BankAccount.Domain.Common
{
    public class EntityBase<TKey> : ICreatedByEntity, IModifiedByEntity
    {
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
    }
}
