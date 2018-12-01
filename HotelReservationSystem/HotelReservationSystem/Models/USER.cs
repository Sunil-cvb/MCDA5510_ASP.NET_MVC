namespace HotelReservationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [Key]
        public long userID { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("User Name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("password")]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("First Name")]
        public string fName { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Last Name")]
        public string lName { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Email ID")]
        public string email { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Phone Number")]
        public string phone { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Street Name")]
        public string street { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("City")]
        public string city { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Province")]
        public string province { get; set; }

        [Required(ErrorMessage = "This field is Required.")]
        [DisplayName("Country")]
        public string country { get; set; }
    }
}
