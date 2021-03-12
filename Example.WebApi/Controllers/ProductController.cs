using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Businees.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApi.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("get")]
        public ActionResult Get()
        {
            var product = _productService.GetList();
            return Ok(product);
        }
    }
}
