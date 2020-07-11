using AutoMapper;
using Mg.Company.Domain.Services.Dto;
using Mg.Company.Infraestructure.Core.Entities;

namespace Mg.Company.Application.WebApi.Handlers
{
    public class SettingAutomapper : Profile
    {
        public SettingAutomapper()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap< EmployeeDto, Employee>();
        }

    }
}
