namespace HotelReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOOKING")]
    public partial class BOOKING
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long bookingID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DisplayName("From")]
        public DateTime fromDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DisplayName("To")]
        [DefaultValue("")]
        public DateTime toDate { get; set; }

        [DisplayName("Adults")]
        [DefaultValue(2)]
        [NotMapped]
        public int adults { get {
                return 1;
            } set {
                this.adults = 1;
            } }


        [Key]
        [Column(Order = 3)]
        public DateTime bookedTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FK_UID { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FK_RID { get; set; }
    }
}
