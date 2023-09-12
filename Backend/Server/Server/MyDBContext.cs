using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class MyDBContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<ClientActivitie> ClientActivities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=HOME;Database=NotesApp;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
