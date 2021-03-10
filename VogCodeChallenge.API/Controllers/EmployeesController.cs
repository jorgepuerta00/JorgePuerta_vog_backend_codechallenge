namespace VogCodeChallenge.API.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Repository;
    using Swashbuckle.AspNetCore.Annotations;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IRepository<Employee> _IRepository;

        public EmployeesController(IRepository<Employee> iRepository)
        {
            _IRepository = iRepository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all employees avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _IRepository.GetAll();
        }

        [HttpGet("/department/{departmentId}")]
        [SwaggerOperation(Summary = "Get all employees by department id avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public async Task<IEnumerable<Employee>> GetEmployeesByDepartmentId(
            [SwaggerParameter(Description = "departmentId is a Guid Type")]
            [FromRoute] string departmentId
        )
        {
            return await _IRepository.GetAll();
        }
    }
}
