using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QDOT.Domain.Interface;
using QDOT.Model;

namespace QDOT.Controllers
{
    //[Produces("application/json")]
    [Route("api/Developer")]
    public class DeveloperController : Controller
    {
        private IDomain<List<Developer>> _domain;

        public DeveloperController(IDomain<List<Developer>> domain)
        {
            this._domain = domain;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return Json(_domain.GetAll());
        }

        [HttpGet]
        [Route("~/api/DeveloperFiltered")]
        public async Task<JsonResult> GetFilteredAsync()
        {
            //QUIZÁS ESTA CONSULTA DEBERÍA IR EN EL DATAACCESS PERO DADA LA FALTA 
            //DE CONOCIMIENTOS NO PUDE HACER QUE FUNCIONE.
            //SOLO DE ESTA MANERA LOGRE SIMULAR DOS ENDPOINTS Y CONSUMIR EL JSON 
            //A TRAVÉS DE UNA LLAMADA HTTP
            var client = new HttpClient();
            var uri = new Uri("http://localhost:51725/api/Developer");
            String respStream = await client.GetStringAsync(uri);
            List<Developer> ser = JsonConvert.DeserializeObject<List<Developer>>(respStream);
            return Json(_domain.GetFiltered(ser));
        }

       
    }
}
