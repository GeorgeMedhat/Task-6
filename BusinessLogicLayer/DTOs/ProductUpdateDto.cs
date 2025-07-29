using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class ProductUpdateDto : ProductCreateDto
    {
        public int id { get; set; }
    }

}
