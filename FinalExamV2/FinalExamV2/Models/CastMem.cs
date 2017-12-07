namespace FinalExamV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CastMem")]
    public partial class CastMem
    {
        [Key]
        public int CastID { get; set; }

        public int? castCrew { get; set; }

        public int? MovieType { get; set; }

        public virtual Actor Actor { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
