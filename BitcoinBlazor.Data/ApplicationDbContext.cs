using BitcoinBlazor.Data.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BitcoinBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserBitcoinAddress> UserBitcoinAddresses { get; set; }

    }
}
