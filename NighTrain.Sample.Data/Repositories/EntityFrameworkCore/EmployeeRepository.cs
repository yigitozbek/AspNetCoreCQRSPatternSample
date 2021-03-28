using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NighTrain.Sample.Data.Context;
using NighTrain.Sample.Domain.Entities;
using NighTrain.Sample.Domain.Interfaces;

namespace NighTrain.Sample.Data.Repositories.EntityFrameworkCore
{
    public class EmployeeRepository : IEmployeeRepository
    {

        protected readonly NighTrainContext Db;

        public EmployeeRepository(NighTrainContext db) => Db = db;

        public async Task<Employee> GetById(int id)
        {
            return await Db.Employees.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Employee>> GetList()
        {
            return await Db.Employees.ToListAsync();
        }

        public async Task Add(Employee employee)
        {
            await Db.AddAsync(employee);
            await Db.SaveChangesAsync();
        }

        public async Task Delete(Employee employee)
        {
            Db.Set<Employee>().Remove(employee);
            await Db.SaveChangesAsync();
        }

        public async Task Update(Employee employee)
        {
            Db.Entry(employee).State = EntityState.Modified;
            await Db.SaveChangesAsync(); 
        }

    }
}
