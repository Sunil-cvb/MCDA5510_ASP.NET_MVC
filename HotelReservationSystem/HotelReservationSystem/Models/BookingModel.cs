namespace HotelReservationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookingModel : DbContext
    {
        public BookingModel()
            : base("name=BookingModel")
        {
        }

        public virtual DbSet<BOOKING> BOOKINGs { get; set; }
        public virtual DbSet<ROOM> ROOMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ROOM>()
                .Property(e => e.roomName)
                .IsUnicode(false);

            modelBuilder.Entity<ROOM>()
                .Property(e => e.roomType)
                .IsUnicode(false);
        }
    }
}
