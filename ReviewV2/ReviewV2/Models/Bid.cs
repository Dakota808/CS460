namespace ReviewV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bid
    {
        [Key]
        public int itemBidID { get; set; }

        public int? itemID { get; set; }

        public int? bider { get; set; }

        [Column(TypeName = "date")]
        public DateTime timeStamps { get; set; }

        [Required]
        [StringLength(255)]
        public string prices { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual Item Item { get; set; }
    }
}
