namespace SampleDataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string PrimaryEmail { get; set; }

        [StringLength(100)]
        public string Email1 { get; set; }

        [StringLength(100)]
        public string Email2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PrimaryPhone { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Phone1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Phone2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeletedDt { get; set; }
    }
}
