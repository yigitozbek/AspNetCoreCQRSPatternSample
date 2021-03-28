using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NighTrain.Sample.Domain.Commands.Employee;
using NighTrain.Sample.Domain.Interfaces;

namespace NighTrain.Sample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMediator _mediator;

        public EmployeeController(IEmployeeRepository employeeRepository, IMediator mediator)
        {
            _employeeRepository = employeeRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var list = await _employeeRepository.GetList();
            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeCommand createEmployeeCommand)
        {
            var result = await _mediator.Send(createEmployeeCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateEmployeeCommand updateEmployeeCommand)
        {
            var result = await _mediator.Send(updateEmployeeCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteEmployeeCommand deleteEmployeeCommand)
        {
            var result = await _mediator.Send(deleteEmployeeCommand);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }

    }
}
