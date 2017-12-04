using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW_5.Models
{
    public class Orders
    {
        // <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Request ID")]
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "ODL Number")]
        public int ODL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(255)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(255)]
        [Display(Name = "Street Address")]
        public string Street { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(255)]
        [Display(Name = "City")]
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(2)]
        [Display(Name = "State")]
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Zip Code")]
        public int Zip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(100)]
        [Display(Name = "County")]
        public string County { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Request Date")]
        public DateTime DateStamp { get; set; }


    }
}