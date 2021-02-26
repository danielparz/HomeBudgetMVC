using HomeBudgetMVC.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudgetMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Item>()
                .HasOne(it => it.Subcategory)
                .WithMany(sub => sub.Items)
                .HasForeignKey(fk => fk.SubcategoryId);
            builder.Entity<Subcategory>()
                .HasOne(a => a.Category)
                .WithMany(b => b.Subcategories)
                .HasForeignKey(fk => fk.CategoryId);
        }
    }
}
