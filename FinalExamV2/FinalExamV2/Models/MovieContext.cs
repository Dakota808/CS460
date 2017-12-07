namespace FinalExamV2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieContext : DbContext
    {
        public MovieContext()
            : base("name=MovieContext")
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<CastMem> CastMems { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
                .Property(e => e.ActorName)
                .IsUnicode(false);

            modelBuilder.Entity<Actor>()
                .HasMany(e => e.CastMems)
                .WithOptional(e => e.Actor)
                .HasForeignKey(e => e.castCrew);

            modelBuilder.Entity<Director>()
                .Property(e => e.DirecName)
                .IsUnicode(false);

            modelBuilder.Entity<Director>()
                .HasMany(e => e.Movies)
                .WithOptional(e => e.Director1)
                .HasForeignKey(e => e.Director);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieName)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.MovieYear)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.CastMems)
                .WithOptional(e => e.Movie)
                .HasForeignKey(e => e.MovieType);
        }
    }
}
