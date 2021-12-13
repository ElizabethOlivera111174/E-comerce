using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNC.Domain.DTOs.CategoryDTOs
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MetaData { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
    }
}
