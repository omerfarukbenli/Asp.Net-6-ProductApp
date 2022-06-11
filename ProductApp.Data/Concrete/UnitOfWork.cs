using ProductApp.Data.Abstract;
using ProductApp.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductAppContext _context;

        public UnitOfWork(ProductAppContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
