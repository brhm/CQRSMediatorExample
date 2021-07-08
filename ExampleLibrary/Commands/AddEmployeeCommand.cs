using ExampleLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary.Commands
{
    public record AddEmployeeCommand(string FirstName,string LastName):IRequest<EmployeeModel>;
    
}
