namespace FinalExamV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            CastMems = new HashSet<CastMem>();
        }

        [Required]
        [StringLength(50)]
        public string MovieName { get; set; }

        [Required]
        [StringLength(50)]
        public string MovieYear { get; set; }

        public int MovieID { get; set; }

        public int? Director { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CastMem> CastMems { get; set; }

        public virtual Director Director1 { get; set; }
    }
}
