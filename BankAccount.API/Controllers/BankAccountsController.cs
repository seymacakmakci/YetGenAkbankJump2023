using System;
using BankAccount.API.Models;
using BankAccount.Domain.Entities;
using BankAccount.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BankAccount.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountsController : ControllerBase
    {
        private readonly BankDbContext _context;

        public BankAccountsController(BankDbContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]
        public void SetDefaultBankAccounts()
        {
            List<BankAccount> bankAccounts = new()
            {
                new BankAccount { Id = Guid.NewGuid(), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "John", LastName = "Doe", PhoneNumber = "5523367351", Balance = 1000, Address = "123 Main St" },
                new BankAccount { Id = Guid.NewGuid(), CreatedOn = DateTime.UtcNow, CreatedByUserId = "1", FirstName = "Alice", LastName = "Smith", PhoneNumber = "5432435342", Balance = 1500, Address = "456 Oak St" },
                // Diğer banka hesaplarını buraya ekleyin
            };

            _context.BankAccounts.AddRange(bankAccounts);
            _context.SaveChanges();
        }

        [HttpGet("[action]/{bankAccountId:guid}")]
        public IActionResult GetBankAccountData(Guid bankAccountId)
        {
            var bankAccount = _context.BankAccounts.FirstOrDefault(x => x.Id == bankAccountId);

            if (bankAccount == null)
            {
                return NotFound();
            }

            var response = new GetBankAccountDataResponseModel
            {
                FirstName = bankAccount.FirstName,
                LastName = bankAccount.LastName,
                Balance = bankAccount.Balance,
                Address = bankAccount.Address
            };

            return Ok(response);
        }
    }

    public class GetBankAccountDataResponseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}

