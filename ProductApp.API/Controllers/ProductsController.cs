using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Business.Abstract;
using ProductApp.Entity.Dto;
using ProductApp.Entity.Models;

namespace ProductApp.API.Controllers
{
   
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _service;

        public ProductsController(IMapper mapper, IService<Product> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductCreateDto productcrDto)
        {
            var product = await _service.AddAsync(_mapper.Map<Product>(productcrDto));
            var productDtos = _mapper.Map<ProductCreateDto>(product);
            return CreateActionResult(CustomResponseDto<ProductCreateDto>.Success(201, productcrDto)); //201 created //oluşturuldu
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto) //güncellemede bir şey dönmüyor, no content //product dto yu kullandığımız için createdate gelecek onun gelmesini istemiyorsak productupdatedto kullanabiliriz
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204)); //204 nocontent
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
