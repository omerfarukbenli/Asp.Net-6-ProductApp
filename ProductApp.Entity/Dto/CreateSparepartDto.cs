using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entity.Dto
{
    public class CreateSparepartDto
    {
        public string SparepartCode { get; set; }
        public string SparepartName { get; set; }
        public int SparepartPrice { get; set; }
        public int[] Products { get; set; }
    }
}
