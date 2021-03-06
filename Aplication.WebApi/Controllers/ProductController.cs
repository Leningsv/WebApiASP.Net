﻿using Aplication.Data;
using Aplication.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aplication.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private ProductService productService = new ProductService();
        [HttpGet]
        [ActionName("NameProducts")]
        public IEnumerable<Product> GetStoreProduts()
        {
            return productService.GetProducts();
        }
        [HttpGet]
        public IHttpActionResult GetProdutc(int id)
        {
            var product = productService.GetProduct(id);
            if(product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }
        [HttpPost]
        public IHttpActionResult Post(Product product)
        {
            var isSave=productService.SaveProduct(product);
            if (isSave == true)
                return Ok();
            return BadRequest();
        }
        [HttpPut]
        public IHttpActionResult Put(Product product)
        {
            var isUpdated = productService.UpdateProduct(product.Id, product);
            if (isUpdated == true)
                return Ok();
            return BadRequest();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var isDeleted = productService.DeleteProduct(id);
            if (isDeleted == true)
                return Ok();
            return BadRequest();
        }
    }
}
