using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.Entities
{
    public class Role : EntityBase
    {
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }

        [Column(TypeName = "VARHCAR(255)")]
        public string Description { get; set; }
    }
}
