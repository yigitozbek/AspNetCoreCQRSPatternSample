using System;
using System.ComponentModel.DataAnnotations;

namespace NighTrain.Sample.Domain.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
