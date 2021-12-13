using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class Client : EntityBase
    {
        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(320)")]
        [MaxLength(320)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Password { get; set; }

    }
}
