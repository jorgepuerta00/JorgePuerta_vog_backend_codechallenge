namespace VogCodeChallenge.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Swashbuckle.AspNetCore.Annotations;
    using vogCodeChallenge.Common.Repository;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IRepository<Department> _IRepository;

        public DepartmentController(IRepository<Department> iRepository)
        {
            _IRepository = iRepository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all departments avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public Task<IEnumerable<Company>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}