using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Business.Abstract;
using ProductApp.Entity.Dto;
using ProductApp.Entity.Models;

namespace ProductApp.API.Controllers
{
   
    public class SparepartsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Sparepart> _service;
        private readonly ISparepartService _sparepartService;

        public SparepartsController(IMapper mapper, IService<Sparepart> service, ISparepartService sparepartService)
        {
            _mapper = mapper;
            _service = service;
            _sparepartService = sparepartService;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var spareparts = await _service.GetAllAsync();
            var sparepartsDtos = _mapper.Map<List<SparepartDto>>(spareparts.ToList());
            return CreateActionResult(CustomResponseDto<List<SparepartDto>>.Success(200, sparepartsDtos));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSparepartDto productDto)
        {
            return Ok(await _sparepartService.AddProductAndSparepart(productDto));
        }
    }
}
