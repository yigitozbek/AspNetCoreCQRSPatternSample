using System;

namespace NighTrain.Sample.Domain.Commands.Employee
{
    public class UpdateEmployeeCommand : BaseEmployeeCommand 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}