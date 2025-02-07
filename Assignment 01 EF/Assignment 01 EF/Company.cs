using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_EF_
{
    internal class Company(): base ()
    {



        public class CompanyDbContext : DbContext
        {
            public CompanyDbContext() : base()
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=CompanyG84;Trust_Connection=true");
            }

            public DbSet<Employee> Employees { get; set; }
        }


    }



