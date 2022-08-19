using Mapster.Core.Student.Commands;
using Mapster.Core.Student.Contracts.Commands;
using Mapster.Core.Student.Contracts.Mapper;
using Mapster.Core.Student.Contracts.Queries;
using Mapster.Core.Student.Mapper;
using Mapster.Core.Student.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Mapster.Core.Student
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentMapper, StudentMapper>();

            services.AddTransient<ICreateStudentCommand, CreateStudentCommand>();
            services.AddTransient<IGetStudentQuery, GetStudentQuery>();
            services.AddTransient<IGetAllStudentQuery, GetAllStudentQuery>();

            return services;

        }
    }
}
