using System;
using System.Collections.Generic;
using System.Text;
using ASP_OneLove.Models.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP_OneLove.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Clothes> Clothes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
