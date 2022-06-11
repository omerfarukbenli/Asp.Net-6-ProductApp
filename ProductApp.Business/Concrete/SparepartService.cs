using AutoMapper;
using ProductApp.Business.Abstract;
using ProductApp.Data.Abstract;
using ProductApp.Entity.Dto;
using ProductApp.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Business.Concrete
{
    public class SparepartService : ISparepartService
    {
        private readonly ISparepartRepository _sparepartRepository;
        private readonly IMapper _mapper;

        public SparepartService(ISparepartRepository sparepartRepository, IMapper mapper)
        {
            _sparepartRepository = sparepartRepository;
            _mapper = mapper;
        }

        public async Task<Sparepart> AddProductAndSparepart(CreateSparepartDto sparepart)
        {
            var product = _mapper.Map<Sparepart>(sparepart);
            await _sparepartRepository.AddSparepart(product);
            foreach (var category in sparepart.Products)
            {
                await _sparepartRepository.AddProductSparepart(product.Id, category);
            }
            return product;
        }
    }
}
