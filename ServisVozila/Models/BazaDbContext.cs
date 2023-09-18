using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServisVozila.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BazaDbContext : DbContext
    {
        public DbSet<Klijenti> PopisKlijenata { get; set; }

        public DbSet<kvar> PopisUsluga { get; set; }

        public DbSet<Automobil> PopisAutomobila { get; set; }

        public DbSet<radnik> PopisRadnika { get; set; }


        public DbSet<odjel> PopisOdjela { get; set; }

        public DbSet<Korisnik> PopisKorisnika { get; set; }

        public DbSet<Ovlast> PopisOvlasti { get; set; }




    }
}