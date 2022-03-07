using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class WUNContext :DbContext{

        public DbSet<Stanar> Stanari {get; set;}
        public DbSet<Stan> Stanovi {get; set;}
        public DbSet<Sastanak> Sastanci {get; set;}
        public DbSet<Racun> Racuni {get; set;}
        public DbSet<Predlog> Predlozi {get; set;}
        public DbSet<Poruka> Cet {get; set;}
        public DbSet<StavkaOglasneTable> OglasnaTabla {get; set;}
        public DbSet<Obavestenje> Obavestenja {get; set;}
        public DbSet<Zgrada> Zgrade {get;set;}
        public DbSet<StanarGlasaoZaPredlog> StanariZaPredloge {get; set;}
        public DbSet<StanarGlasaoProtivPredloga> StanariProtivPredloga {get; set;}
        public DbSet<StanarZaSastanak> StanariZaSastanak {get; set;}
        public DbSet<StanarNeZaSastanak> StanariNeZaSastanak {get; set;}
        public DbSet<NotifikacijeStanara> NotifikacijeStanara {get; set;}


        public WUNContext(DbContextOptions options):base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stanar>().HasIndex(s => s.Email).IsUnique();

        }

    }


}