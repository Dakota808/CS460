namespace HW_8_V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Artist")]
    public partial class Artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artist()
        {
            Artworks = new HashSet<Artwork>();
        }

        [Required]
        [StringLength(50)]
        public string Names { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:mm/dd/yyyy}")]
        [RestictedDate]
        public DateTime DOB { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }

        [Key]
        public int Artkey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artwork> Artworks { get; set; }

        public class RestictedDate : ValidationAttribute
        {
            public override bool IsValid(object date)
            {
                DateTime Date = (DateTime)date;
                return (DateTime)date < DateTime.Now;
            }

        }
    }
}
