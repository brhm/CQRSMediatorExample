using ExampleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        private List<EmployeeModel> _employees = new(); //C# 9 syntax.
        public DataAccess()
        {
            _employees.Add(new EmployeeModel() { Id = 1, FirstName = "ibrahim", LastName = "Keskin" });
            _employees.Add(new EmployeeModel() { Id = 2, FirstName = "Maşuk", LastName = "Demir" });
            _employees.Add(new EmployeeModel() { Id = 3, FirstName = "Ayşe", LastName = "Uçar" });
        }
        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() { FirstName = firstName, LastName = lastName };
            newEmployee.Id = _employees.Max(p => p.Id) + 1;

            _employees.Add(newEmployee);
            return newEmployee; 
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }
    }
}
