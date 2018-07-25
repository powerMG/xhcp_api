﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xhcp_Service.ProductService;

namespace API_XhcpProject.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IProductService _productService;
        public ValuesController(IProductService productService)
        {
            _productService = productService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = _productService.Test();
            return new string[] { "value1", result };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
