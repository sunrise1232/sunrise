using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sunrise2._0.Storage.Entity
{
    public class Tour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        //public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Rating{ get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int HotelId { get; set; }
        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
