using System;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Book> Books {get; set;}
    }
}