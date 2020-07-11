using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Mg.Company.Application.WebApi.Handlers;
using Mg.Company.Domain.Services.Dto;
using Mg.Company.Domain.Services.Interfaces;
using Mg.Company.Domain.ServicesTests;
using Mg.Company.Infraestructure.Core;
using Mg.Company.Infraestructure.Core.Repository;
using Mg.Company.Infraestructure.Core.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mg.Company.Domain.Services.Tests
{
    [TestClass()]
    public class EmployeesServiceTests
    {
        private ApplicationDbContext _context;
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private IEmployeesService _employeesService;

        public EmployeesServiceTests()
        {
            var services = new ServiceCollection();           
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            this._context = ContextMock.Seed();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SettingAutomapper());
            });

            this._mapper = mappingConfig.CreateMapper();
            services.AddSingleton(_mapper);
        }


        [TestInitialize]
        public void Init()
        {   
            this._unitOfWork = new UnitOfWork(_context);          
            this._employeesService = new EmployeesService(this._unitOfWork, this._mapper);
        }

        [TestMethod()]
        public void GetAllEmployeesTest()
        {
            IEnumerable<EmployeeDto> employees = this._employeesService.GetAllEmployees();
            Assert.IsTrue(employees.Any());
            Assert.IsTrue(employees.ToList().Count > 0);
        }

        [TestMethod()]
        public void GetEmployeesByDocumentNumberTest()
        {
            EmployeeDto employees = this._employeesService.GetEmployeesByDocumentNumber("12345688");
            Assert.IsNotNull(employees);            
        }
    }
}