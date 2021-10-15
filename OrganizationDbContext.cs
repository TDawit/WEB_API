using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class OrganizationDbContext:DbContext //inhertance 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(("Server=DAWITT\\INSTA1;Database=APIPRAC_DAL;Trusted_connection=True;"));
        }
        public DbSet<Departments> Departments { get; set; }
    }
}
