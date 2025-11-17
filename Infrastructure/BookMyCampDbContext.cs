using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class BookMyCampDbContext : DbContext
    {
        public BookMyCampDbContext(DbContextOptions<BookMyCampDbContext> options)
            : base(options) { }

        public virtual DbSet<AddOn> AddOns { get; set; }

        public virtual DbSet<AddOnLine> AddOnsLine { get; set; }

        public virtual DbSet<Booking> Bookings { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<EmployeeLanguage> EmployeeLanguages { get; set; }

        public virtual DbSet<Facility> Facilities { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Language> Languages { get; set; }

        public virtual DbSet<Resource> Resources { get; set; }

        public virtual DbSet<SeasonPrice> SeasonPrices { get; set; }

        public virtual DbSet<TempUser> TempUsers { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Guest>().UseTpcMappingStrategy();

        }
    }

}
