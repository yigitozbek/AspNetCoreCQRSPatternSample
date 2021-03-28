using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NighTrain.Sample.Domain.Commands.Employee;
using NighTrain.Sample.Domain.Interfaces;
using NighTrain.Sample.Domain.Results;

namespace NighTrain.Sample.Application.Handlers.Employee
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Result>
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMediator _mediator;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository, IMediator mediator)
        {
            _employeeRepository = employeeRepository;
            _mediator = mediator;
        }

        public async Task<Result> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            await _employeeRepository.Add(new Domain.Entities.Employee()
            {
                Id = request.Id,
                Name = request.Name,
                Surname = request.Surname,
                Birthday = request.Birthday
            });

            return new Result(true,"Successful");
        }
    }
}
