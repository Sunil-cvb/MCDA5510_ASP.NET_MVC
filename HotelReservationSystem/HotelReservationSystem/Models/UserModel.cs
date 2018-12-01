namespace HotelReservationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserModel : DbContext
    {
        public UserModel()
            : base("name=DbModels")
        {
        }

        public virtual DbSet<USER> USERs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USER>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.fName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.lName)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.country)
                .IsUnicode(false);
        }
    }
}
