using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    [Table("tbBook")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public int BookQuantity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal BookPrice { get; set; }
    }
}
