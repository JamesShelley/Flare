using BitcoinBlazor.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace BitcoinBlazor.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserBitcoinAddress> UserBitcoinAddresses { get; set; }

    }
}
