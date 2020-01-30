namespace DiplomLast.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiplomDB : DbContext
    {
        public DiplomDB()
            : base("name=DiplomDB")
        {
        }

        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gorod> Gorods { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Oblast> Oblasts { get; set; }
        public virtual DbSet<obrazovanye> obrazovanyes { get; set; }
        public virtual DbSet<Otsen4ikTEstov> Otsen4ikTEstov { get; set; }
        public virtual DbSet<QuizResult> QuizResults { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<semeynoePolojenie> semeynoePolojenies { get; set; }
        public virtual DbSet<Tester> Testers { get; set; }
        public virtual DbSet<TipVakansya> TipVakansyas { get; set; }
        public virtual DbSet<university> universities { get; set; }
        public virtual DbSet<Vakansya> Vakansyas { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    var foo = modelBuilder.Entity<Foo>();
        //    foo.Property(f => f.IAmSoSmall).HasColumnType("smalldatetime");

        //    base.OnModelCreating(modelBuilder);
        //}
    //}

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        var foo = modelBuilder.Entity<QuizResult>();
        foo.Property(f => f.testerDate).HasColumnType("smalldatetime");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Oblasts)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.idCountry);

            modelBuilder.Entity<Oblast>()
                .HasMany(e => e.Adresses)
                .WithOptional(e => e.Oblast)
                .HasForeignKey(e => e.idOBlast);

            modelBuilder.Entity<Oblast>()
                .HasMany(e => e.Gorods)
                .WithOptional(e => e.Oblast)
                .HasForeignKey(e => e.idOBlast);

            modelBuilder.Entity<Oblast>()
                .HasMany(e => e.Regions)
                .WithOptional(e => e.Oblast)
                .HasForeignKey(e => e.idOBlast);

            modelBuilder.Entity<obrazovanye>()
                .HasMany(e => e.Testers)
                .WithOptional(e => e.obrazovanye)
                .HasForeignKey(e => e.obrazavanyeID);

            modelBuilder.Entity<QuizResult>()
                .Property(e => e.userPoint)
                .HasPrecision(18, 0);

            modelBuilder.Entity<QuizResult>()
                .Property(e => e.maxPoint)
                .HasPrecision(18, 0);

            modelBuilder.Entity<semeynoePolojenie>()
                .HasMany(e => e.Testers)
                .WithOptional(e => e.semeynoePolojenie)
                .HasForeignKey(e => e.semeynoePolojenyeID);

            modelBuilder.Entity<Tester>()
                .Property(e => e.opitRboty)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TipVakansya>()
                .HasMany(e => e.Vakansyas)
                .WithOptional(e => e.TipVakansya1)
                .HasForeignKey(e => e.tipVAkansya);

            modelBuilder.Entity<Vakansya>()
                .HasMany(e => e.Testers)
                .WithOptional(e => e.Vakansya)
                .HasForeignKey(e => e.zhelaemayaVakansya);
        }
    }
}
