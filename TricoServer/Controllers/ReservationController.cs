using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TricoServer.Domain;

namespace TricoServer.Controllers
{
    [Route("api/reservations")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        // GET api/values
        [HttpGet()]
        public ActionResult<IEnumerable<Reservation>> Get(string email)
        {
            return  DataRepository.Instance.GetReservations(email);
        }

        // POST api/values
        [HttpPost("reserve")]
        public void Post([FromBody] ReservationInfo value)
        {
            var workplace = DataRepository.Instance.GetWorplaces().First(x=>x.Id==value.Workplace);
            DataRepository.Instance.Reserve(new User(){Mail = value.Mail}, workplace, value.Date);
        }

    }

    public class ReservationInfo
    {
        public long Workplace { get; set; }
        public DateTime Date { get; set; }
        public string Mail { get; set; }
    }
}
