using System;
using BankAccount.Domain.Common;

namespace BankAccount.Domain.Entities
{
    public class BankAccount : EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Balance { get; set; }
        public string Address { get; set; }

    }
}

