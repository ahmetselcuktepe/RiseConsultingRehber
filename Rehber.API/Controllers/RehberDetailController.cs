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
    public class RehberDetailController : ControllerBase
    {

        private IRehberKDetailService _rehberDetailService;

        public RehberDetailController(IRehberKDetailService rehberKDetailService)
        {
            _rehberDetailService = rehberKDetailService;
        }

        [HttpGet]
        public List<RehberKDetail> Get()
        {
            return _rehberDetailService.GetAllRehberKDetails();
        }
    }
}
