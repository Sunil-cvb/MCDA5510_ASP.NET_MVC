namespace HotelReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERBANK")]
    public partial class USERBANK
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(45)]
        public string cardNumber { get; set; }

        public decimal amount { get; set; }

        public int FK_UID { get; set; }
    }
}
