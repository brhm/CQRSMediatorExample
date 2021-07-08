using ExampleLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary.Queries
{
    public record GetEmployeeListQuery():IRequest<List<EmployeeModel>>;

}
