using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using QDOT.Domain.Interface;

namespace QDOT.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IDomain<JArray> domain;

        public ValuesController(IDomain<JArray> _domain)
        {
            this.domain = _domain;
        }

        // GET api/values
        [HttpGet]
        public JArray Get()
        {
            return domain.GetAllJson();
        }

        // GET api/values
        [HttpGet("filtered")]
        public JArray GetFiltered()
        {
            return domain.GetJsonFiltered();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

    }
}
