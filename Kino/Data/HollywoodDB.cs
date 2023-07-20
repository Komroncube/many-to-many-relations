namespace Kino.Data
{
    public class HollywoodDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=root;Database=HollywoodDB");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ActorFilm>().HasKey(sc => new { sc.ActorId, sc.FilmId });
            //modelBuilder.Entity<ActorFilm>()
            //    .HasOne<Film>(sc => sc.Film)
            //    .WithMany(s => s.ActorFilm)
            //    .HasForeignKey(sc => sc.FilmId);
            //modelBuilder.Entity<ActorFilm>()
            //    .HasOne<Actor>(sc => sc.Actor)
            //    .WithMany(s => s.ActorFilm)
            //    .HasForeignKey(sc => sc.ActorId);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<ActorFilm> ActorFilm { get; set; }

    }
}
