namespace VogCodeChallenge.API.Application.Queries
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Dapper;
    using MediatR;
    using Microsoft.Data.SqlClient;
    using ViewModel;
    using vogCodeChallenge.Common.Exceptions;
    using VogCodeChallenge.Common.Configuration;

    public class GetEmployeesByDepartmentIdQueryHandler
    {
        public class Query : IRequest<IEnumerable<EmployeeViewModel>>
        {
            public Query(Guid departmentId)
            {
                DepartmentId = departmentId;
            }

            public Guid DepartmentId { get; set; }
        }

        public class Handler : IRequestHandler<Query, IEnumerable<EmployeeViewModel>>
        {
            private CommonGlobalAppSingleSettings _commonGlobalAppSingleSettings;

            public Handler(CommonGlobalAppSingleSettings commonGlobalAppSingleSettings)
            {
                _commonGlobalAppSingleSettings = commonGlobalAppSingleSettings;
            }

            public async Task<IEnumerable<EmployeeViewModel>> Handle(
                Query query,
                CancellationToken cancellationToken)
            {
                try
                {
                    using (IDbConnection conn = new SqlConnection(_commonGlobalAppSingleSettings.MssqlConnectionString))
                    {
                        string sql =
                            @"
                        SELECT e.Id
                              ,[FirstName]
                              ,[LastName]
                              ,[JobTitle]
                              ,[ResidenceAddress]
                              ,d.Name as DepartmentName
                              ,c.Name as CompanyName
                          FROM Employees e
                            INNER JOIN Departments d ON d.Id = e.DepartmentId
                            INNER JOIN Companies c ON c.Id = d.CompanyId
                            WHERE e.DepartmentId = @DepartmentId";

                        var result = await conn.QueryAsync<EmployeeViewModel>(sql, new { query.DepartmentId });

                        return result.AsEnumerable();
                    }
                }
                catch (Exception e)
                {
                    throw new AppException(e.Message);
                }
            }
        }
    }
}