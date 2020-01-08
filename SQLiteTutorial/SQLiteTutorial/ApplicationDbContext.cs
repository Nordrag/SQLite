using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SQLiteTutorial
{
    public class ApplicationDbContext : DbContext
    {
        private string mPath;

        public ApplicationDbContext()
        {
            mPath = "Asztal/Tutorial.db3";
            Database.EnsureCreated();
        }

        public DbSet<User> UserTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={mPath}");
        }
    }
}
