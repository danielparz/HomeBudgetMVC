﻿using HomeBudgetMVC.Domain.Models;
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

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Item>()
                .HasOne(it => it.Category)
                .WithMany(cat => cat.Items)
                .HasForeignKey(fk => fk.CategoryId);
            builder.Entity<Category>()
                .HasOne(pc => pc.ParentCategory)
                .WithMany(cc => cc.Categories)
                .HasForeignKey(fk => fk.ParentCategoryId);
            builder.Entity<Item>(
                it => it.Property(i => i.Value)
                .HasColumnType("decimal(9, 2)"));
        }
    }
}
