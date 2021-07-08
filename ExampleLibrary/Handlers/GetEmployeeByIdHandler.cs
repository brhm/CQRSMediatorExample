using ExampleLibrary.Models;
using ExampleLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExampleLibrary.Handlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeModel>
    {
        private readonly IMediator _mediator;

        public GetEmployeeByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<EmployeeModel> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employees = await _mediator.Send(new GetEmployeeListQuery());
            var resultEmployee = employees.FirstOrDefault(x => x.Id == request.Id);

            return resultEmployee;
        }
    }
}
