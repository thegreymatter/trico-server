using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using TricoServer.Domain;

namespace TricoServer.Controllers
{
    [Route("api/workplace")]
    [ApiController]
    public class WorkplaceController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Workplace>> Get()
        {
            return DataRepository.Instance.GetWorplaces();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Workplace> Get(long id)
        {
            return DataRepository.Instance.GetWorplaces().FirstOrDefault(x => x.Id == id);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Workplace value)
        {
            value.Id = id;
            DataRepository.Instance.AddWorkplace(value);
        }

 
    }


}
