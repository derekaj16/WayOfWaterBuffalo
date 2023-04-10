using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WayOfWaterBuffalo.Models
{
    public class Burial
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public short squarenorthsouth { get; set; }
        public char headdirection { get; set; }
    }
}