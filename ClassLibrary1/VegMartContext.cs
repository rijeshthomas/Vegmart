using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;

namespace VegMart.DataAccess
{
    public class VegMartContext : DbContext
    {
        public VegMartContext(DbContextOptions<VegMartContext> options) : base(options)
        {
        }


    }
}
