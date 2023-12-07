using System;
namespace BankAccount.API.Models
{
    public class GetBankAccountDataResponseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public string Address { get; set; }
    }
}

