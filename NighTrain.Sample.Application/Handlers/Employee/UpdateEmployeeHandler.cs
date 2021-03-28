using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NighTrain.Sample.Domain.Commands.Employee;
using NighTrain.Sample.Domain.Interfaces;
using NighTrain.Sample.Domain.Results;

namespace NighTrain.Sample.Application.Handlers.Employee
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Result>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMediator _mediator;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository, IMediator mediator)
        {
            _employeeRepository = employeeRepository;
            _mediator = mediator;
        }

        public async Task<Result> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetById(request.Id);
            if (employee == null) return new Result(false, "no such user found.");
            employee.Name = request.Name;
            employee.Surname = request.Surname;
            employee.Birthday = request.Birthday;
            await _employeeRepository.Update(employee); 
            return new Result(true,"Successful");
        }
    }
}