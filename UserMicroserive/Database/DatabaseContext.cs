using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMicroserive.Database.Enities;

namespace UserMicroserive.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //here is the connection string to the database in sql server 
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-M8JPNCH\SQLExpress; 
            initial catalog=UserMicroservice;persist security info=True; user id = Rawinder;password=mds123;");
        }
    }
}

