using System;

namespace Week3_1.Abstract
{
    internal class Person<T> : EntityBase<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
