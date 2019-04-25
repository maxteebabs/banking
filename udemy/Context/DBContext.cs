using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using udemy.Models;

namespace udemy.Context
{
    public class BankContext : DbContext
    {
        public BankContext() : base("GenericBankDB") { }
        public virtual DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}