namespace HW8._2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArtistContext : DbContext
    {
        public ArtistContext()
            : base("name=ArtistContext")
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Artwork> Artworks { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Property(e => e.Names)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Artwork>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Artwork>()
                .HasMany(e => e.Classifications)
                .WithOptional(e => e.Artwork1)
                .HasForeignKey(e => e.artwork);

            modelBuilder.Entity<Classification>()
                .Property(e => e.genres)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.genre1)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Classifications)
                .WithOptional(e => e.Genre)
                .HasForeignKey(e => e.genres);
        }
    }
}
