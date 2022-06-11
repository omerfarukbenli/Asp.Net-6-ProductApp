using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entity.Models
{
    public class Product:BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public ICollection<ProductSparepart> ProductSpareparts { get; set; }
    }
}
