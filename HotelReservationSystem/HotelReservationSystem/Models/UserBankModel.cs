namespace HotelReservationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserBankModel : DbContext
    {
        public UserBankModel()
            : base("name=UserBankModel")
        {
        }

        public virtual DbSet<USERBANK> USERBANKs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USERBANK>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<USERBANK>()
                .Property(e => e.cardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<USERBANK>()
                .Property(e => e.amount)
                .HasPrecision(10, 2);
        }
    }
}
