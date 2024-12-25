using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySX._1.DAL.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string Line { get; set; }

        [Required]
        public int Plan { get; set; }

        [Required]
        public int Target { get; set; }

        [Required]
        public int Result { get; set; }

        [Required]
        public int Achieve { get; set; }

        [Required]
        public double Progress { get; set; }
    }
}
