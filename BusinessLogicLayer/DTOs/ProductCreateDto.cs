using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class ProductCreateDto
    {
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public int categoryId { get; set; }
    }

}
