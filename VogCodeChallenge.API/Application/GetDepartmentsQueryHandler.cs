namespace VogCodeChallenge.API.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.AggregatesModel.DepartmentAggregate;
    using Infraestructure.Repository;
    using MediatR;
    using vogCodeChallenge.Common.Exceptions;

    public class GetDepartmentsQueryHandler
    {
        public class Query : IRequest<IEnumerable<Department>>
        {

        }

        public class Handler : IRequestHandler<Query, IEnumerable<Department>>
        {
            private IRepository<Department> _repository;

            public Handler(IRepository<Department> repository)
            {
                _repository = repository;
            }

            public async Task<IEnumerable<Department>> Handle(
                Query query,
                CancellationToken cancellationToken)
            {
                try
                {
                    return await _repository.GetAll();
                }
                catch (Exception e)
                {
                    throw new AppException(e.Message);
                }
            }
        }
    }
}
