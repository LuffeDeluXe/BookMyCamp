using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class BookMyCampDbContextFactory : IDesignTimeDbContextFactory<BookMyCampDbContext>
    {
        public BookMyCampDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookMyCampDbContext > ();
            optionsBuilder.UseSqlServer("Server=87.104.67.219;Database=BookMyCampDb;User Id=sa;Password=Datadragon13;TrustServerCertificate=True;");
            return new BookMyCampDbContext(optionsBuilder.Options);

        }

    }
}
