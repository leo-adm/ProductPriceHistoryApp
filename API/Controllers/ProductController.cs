using API.Models.PriceRegister;
using API.Models.Product;
using AutoMapper;
using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductsRepository _repository;

        public ProductController(
            IMapper mapper,
            IProductsRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductReadModel>>> GetProducts()
        {
            var products = await _repository.GetProducts();

            var productModels = _mapper.Map<List<ProductReadModel>>(products);

            return Ok(productModels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductReadModel>> GetProduct(int id)
        {
            var product = await _repository.GetProduct(id);

            if (product is null) return NotFound();

            return Ok(_mapper.Map<ProductReadModel>(product));
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(ProductCreateModel createProductModel)
        {
            var product = _mapper.Map<Product>(createProductModel);

            await _repository.AddProduct(product);

            await _repository.SaveChanges();

            return Ok();
        }

        [HttpPost("{productId}")]
        public async Task<ActionResult> RegisterProductPrice([FromBody]PriceRegisterCreateModel createPriceRegisterModel, int productId)
        {
            var product = await _repository.GetProduct(productId);

            if (product is null) return NotFound();

            var priceRegister = _mapper.Map<PriceRegister>(createPriceRegisterModel);

            await _repository.RegisterPrice(priceRegister, productId);

            await _repository.SaveChanges();

            return Ok();
        }
    }
}
