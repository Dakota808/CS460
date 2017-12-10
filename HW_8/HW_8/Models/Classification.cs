namespace HW_8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Classification")]
    public partial class Classification
    {
        [Key]
        [Column("classification")]
        public int classification1 { get; set; }

        public int? artwork { get; set; }

        [StringLength(255)]
        public string genres { get; set; }

        public virtual Artwork Artwork1 { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
