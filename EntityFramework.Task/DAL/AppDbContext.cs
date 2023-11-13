using EntityFramework.Task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Task.DAL
{
    internal class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-H4L34LR; database = EntityTask; Trusted_connection=true; Integrated security = true; Encrypt = false;");
        }

        public DbSet <Student> students { get; set; }
        public DbSet <Group> groups { get; set; }
    }
}
