using FunyJapanese.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace FunyJapanese.Data
{
    class AphabetContext : DbContext
    {
        public DbSet<Alphabet> tblAlphabet { get; set; }
        public DbSet<Wordcs> tblWord { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = "FunyJapanese.db";
            try
            {
                optionsBuilder.UseSqlite($"Data source={dbPath}");
            }
            catch (InvalidOperationException)
            {
            }
        }

    }
}
