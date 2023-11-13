using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotel_api.Domain.Extencions;
using hotel_api.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace hotel_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospedeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Serialize([FromBody] Hospede model)
        {
            var result = model.SerializeToStringProtobuf();

            return Ok(result);
        }

        [HttpPost("deserialize")]
        public IActionResult Deserialize([FromBody] string protobuf)
        {
            var result = protobuf.DeserializeFromStringProtobuf<Hospede>();

            return Ok(result);
        }
    }
}