using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NighTrain.Sample.Domain.Commands.Employee;
using NighTrain.Sample.Domain.Interfaces;
using NighTrain.Sample.Domain.Results;

namespace NighTrain.Sample.Application.Handlers.Employee
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Result>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMediator _mediator;

        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository, IMediator mediator)
        {
            _employeeRepository = employeeRepository;
            _mediator = mediator;
        }

        public async Task<Result> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetById(request.Id);
            if (employee == null) return new Result(false, "no such user found.");
            await _employeeRepository.Delete(employee);
            return new Result(true, "Successful");
        }
    }
}