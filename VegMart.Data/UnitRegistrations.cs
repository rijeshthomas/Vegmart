using System;
using System.Collections.Generic;
using System.Text;

namespace VegMart.Data
{
    public class UnitRegistrations
    {
        public Guid Id { get; set; }

        public string RegistratedEmail { get; set; }

        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; }

    }
}
