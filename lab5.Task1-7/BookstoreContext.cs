using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.EntityFrameworkCore;
using static lab5.Task1_7.Form1;

namespace lab5.Task1_7
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}
