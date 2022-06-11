using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entity.Models
{
    public class Sparepart:BaseEntity
    {
        public string SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public int SparepartPrice { get; set; }
        public ICollection<ProductSparepart> ProductSpareparts { get; set; }
    }
}
