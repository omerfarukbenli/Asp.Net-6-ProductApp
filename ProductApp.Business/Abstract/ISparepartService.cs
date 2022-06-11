using ProductApp.Entity.Dto;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Business.Abstract
{
    public interface ISparepartService
    {
        Task<Sparepart> AddProductAndSparepart(CreateSparepartDto sparepart);
    }
}
