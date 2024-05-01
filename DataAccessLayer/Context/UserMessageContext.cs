using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class UserMessageContext : IdentityDbContext<AppUser, AppRole, int>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C1IT2N4\\MSSQLSERVER02;initial catalog=DbMessageApp;integrated security=true;");
        }
        public DbSet<UserMessage> UsersMessages { get; set; }
        public DbSet<Draft> Drafts { get; set; }
    }
}
