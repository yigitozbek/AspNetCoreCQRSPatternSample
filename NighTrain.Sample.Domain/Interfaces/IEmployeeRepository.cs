using System.Collections.Generic;
using System.Threading.Tasks;
using NighTrain.Sample.Domain.Entities;

namespace NighTrain.Sample.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
        Task<List<Employee>> GetList();
        Task Add(Employee employee);  
        Task Update(Employee employee);
        Task Delete(Employee employee);
    }
}
