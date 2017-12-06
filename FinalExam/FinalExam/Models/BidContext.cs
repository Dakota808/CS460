namespace FinalExam.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BidContext : DbContext
    {
        public BidContext()
            : base("name=BidContext")
        {
        }

        public virtual DbSet<Bid> Bids { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bid>()
                .Property(e => e.prices)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .Property(e => e.BuyersName)
                .IsUnicode(false);

            modelBuilder.Entity<Buyer>()
                .HasMany(e => e.Bids)
                .WithOptional(e => e.Buyer)
                .HasForeignKey(e => e.bider);

            modelBuilder.Entity<Item>()
                .Property(e => e.itemName)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.itemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .Property(e => e.SellersName)
                .IsUnicode(false);

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Seller1)
                .HasForeignKey(e => e.seller);
        }
    }
}
