using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entity.Models
{
    public class ProductSparepart
    {
      
        public int SparepartID { get; set; }
        public Sparepart Sparepart { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
