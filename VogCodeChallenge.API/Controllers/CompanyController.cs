namespace VogCodeChallenge.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Swashbuckle.AspNetCore.Annotations;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly ILogger<object> _logger;

        public CompanyController(ILogger<object> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all companies avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public Task<IEnumerable<object>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
