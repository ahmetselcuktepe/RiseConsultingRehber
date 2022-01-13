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

        public RehberController()
        {
            _rehberService = new RehberKManager();
        }

        [HttpGet]
        public List<RehberK> Get()
        {
            return _rehberService.GetAllRehberKs();
        }

        [HttpGet("{guid}")]
        public RehberK Get(Guid guid)
        {
            return _rehberService.GetRehberKByGuid(guid);
        }
    }
}
