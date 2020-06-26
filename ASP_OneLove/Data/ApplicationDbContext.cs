using System;
using System.Collections.Generic;
using System.Text;
using ASP_OneLove.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP_OneLove.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Building> Buildings { get; set; }

        public DbSet<ASP_OneLove.Models.Apartment> Apartment { get; set; }

        public DbSet<ASP_OneLove.Models.Address> Address { get; set; }
    }
}
