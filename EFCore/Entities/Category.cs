using System;
using System.Collections.Generic;

namespace EFCore.Entities
{
    public class Category : EFCore.Common.EntityBase<int>
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Category(int id, DateTimeOffset createdOn, string name) : base(id, createdOn)
        {
            Name = name;
        }
    }
}
