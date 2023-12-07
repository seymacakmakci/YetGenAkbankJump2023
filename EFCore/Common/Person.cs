﻿using System;
namespace EFCore.Common
{
    public class Person<TKey> : EntityBase<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(TKey id, DateTimeOffset createdOn, string firstName, string lastName) : base(id, createdOn)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}