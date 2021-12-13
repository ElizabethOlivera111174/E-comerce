using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.ProducDTO
{
    public class ProductDTO
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        [MaxLength(255)]

        public string MetaTitle { get; set; }

        [Required]
        [MaxLength(255)]
        public string MetaDescription { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int SubCategoryId { get; set; }
    }
}
