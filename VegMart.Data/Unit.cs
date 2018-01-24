using System;

namespace VegMart.Data
{
    public class Unit
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string BankAccountNumber { get; set; }

        public string Address { get; set; }

        public string status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Guid RegisteredBy { get; set; }

    }
}
