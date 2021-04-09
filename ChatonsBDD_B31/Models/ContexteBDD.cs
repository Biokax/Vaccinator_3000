using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatonsBDD_B31.Models;

namespace ChatonsBDD_B31.Models
{
    public class ContexteBDD : DbContext
    {
        public DbSet<Injection> Injections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //en vrai il ne faudrait pas mettre la chaine de connexion ici, mais dans les paramètres appsettings
            //todo mettre la chaine de connexion ailleur
            options.UseSqlite("Data Source=chatons.db");
        }

        public DbSet<ChatonsBDD_B31.Models.User> User { get; set; }

        public DbSet<ChatonsBDD_B31.Models.Vaccine> Vaccine { get; set; }

        public DbSet<ChatonsBDD_B31.Models.Injection> Injection { get; set; }
    }
}
