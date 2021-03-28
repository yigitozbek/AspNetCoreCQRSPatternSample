using MediatR;
using NighTrain.Sample.Domain.Results;

namespace NighTrain.Sample.Domain.Commands.Employee
{
    public abstract class BaseEmployeeCommand : IRequest<Result> 
    {
        public int Id { get; set; }
    }
}
