using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rehber.Business.Abstract;
using Rehber.Business.Concrete;
using Rehber.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RehberController : ControllerBase
    {
        private IRehberKService _rehberService;

        public RehberController(IRehberKService rehberKService)
        {
            _rehberService = rehberKService;
        }
        /// <summary>
        /// Telefondaki kayıtlı tüm kişileri göstermektedir.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var Rehber = _rehberService.GetAllRehberKs();
            return Ok(Rehber);
        }

        [HttpGet("{guid}")]
        public IActionResult Get(Guid guid)
        {
            var Rehber = _rehberService.GetRehberKByGuid(guid);
            if (Rehber != null)
            {
                return Ok(Rehber);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] RehberK rehber)
        {
            var Rehber = _rehberService.CreateRehberK(rehber);
            return CreatedAtAction("Get", new { Guid = Rehber.Id }, Rehber);
        }

        [HttpPut]
        public IActionResult Put([FromBody] RehberK rehber)
        {
            if (_rehberService.GetRehberKByGuid(rehber.Id)!=null)
            {
                var Rehber = _rehberService.UptadeRehberK(rehber);
                return Ok(Rehber);
            }
            return NotFound();
        }

        [HttpDelete("{guid}")]
        public IActionResult Delete(Guid guid)
        {
            if (_rehberService.GetRehberKByGuid(guid) != null)
            {
                 _rehberService.DeleteRehberK(guid);
                return Ok();
            }
            return NotFound();
            
        }
    }
}
