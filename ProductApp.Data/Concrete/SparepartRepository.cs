using ProductApp.Data.Abstract;
using ProductApp.Data.Context;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data.Concrete
{
    public class SparepartRepository : ISparepartRepository
    {
        private readonly ProductAppContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public SparepartRepository(ProductAppContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public async Task AddProductSparepart(int id, int pro)
        {
            var product = _context.Products.Find(pro);

            var sparepart = _context.Spareparts.FirstOrDefault(a => a.Id == id);

            ProductSparepart newprocat = new ProductSparepart
            {
                Product = product,
                Sparepart = sparepart
            };
            await _context.Set<ProductSparepart>().AddAsync(newprocat);
            await _unitOfWork.CommitAsync();
        }

        public async Task AddSparepart<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
