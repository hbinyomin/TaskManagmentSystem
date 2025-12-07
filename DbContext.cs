using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagmentSystem {
    internal class TaskDbContext : DbContext {
        public DbSet<Task> Tasks { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TASKMANAGEMENTSYSTEM;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}