using BookStoreDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreDAL.Context
{
    public class BooksStoreContext : DbContext
    {
        public BooksStoreContext(DbContextOptions<BooksStoreContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(b =>
            {
                b.HasKey(k => k.Id);
                b.HasOne(a => a.Author).WithMany(a => a.Books).HasForeignKey(k => k.AuthorId);
            });

            modelBuilder.Entity<Author>(a =>
            {
                a.HasKey(k => k.Id);
            });
        }
    }

    public class DesignTimeDBContextFactory : IDesignTimeDbContextFactory<BooksStoreContext>
    {
        public BooksStoreContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BooksStoreContext>();
            builder.UseSqlServer("Server=localhost;Database=BookStore;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new BooksStoreContext(builder.Options);
        }
    }
}
