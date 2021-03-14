namespace VogCodeChallenge.API.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    using Application.Queries;
    using Application.ViewModel;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Get all employees avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public async Task<IEnumerable<EmployeeViewModel>> GetAll()
        {
            return await _mediator.Send(new GetEmployeeQueryHandler.Query());
        }

        [HttpGet("/department/{departmentId}")]
        [SwaggerOperation(Summary = "Get all employees by department id avaibles")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Succesfully Request")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public async Task<IEnumerable<EmployeeViewModel>> GetEmployeesByDepartmentId(
            [SwaggerParameter(Description = "departmentId is a Guid Type")]
            [FromRoute] Guid departmentId
        )
        {
            return await _mediator.Send(new GetEmployeesByDepartmentIdQueryHandler.Query(departmentId));
        }
    }
}
