namespace VogCodeChallenge.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Repository;
    using Swashbuckle.AspNetCore.Annotations;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly IRepository<Company> _IRepository;

        public CompanyController(IRepository<Company> iRepository)
        {
            _IRepository = iRepository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all companies avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public Task<IEnumerable<Company>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
