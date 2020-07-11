using System.Collections.Generic;
using System.Linq;
using Mg.Company.Domain.Services.Dto;
using Mg.Company.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Mg.Company.Application.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            this._employeesService = employeesService;
        }


        /// <summary>
        /// Returns all company employees
        /// </summary>
        /// <returns>List<EmployeeDto></returns>
        [HttpGet]
        public IActionResult Get()
        {
            List<EmployeeDto> employees = this._employeesService.GetAllEmployees().ToList();

            if (employees.Any())
                return Ok(employees);

            return BadRequest();
        }


        /// <summary>
        /// Returns an employee by document number
        /// </summary>
        /// <param name="documentNumber">Document Number</param>
        /// <returns></returns>
        [HttpGet("{documentNumber}")]
        public IActionResult Get(string documentNumber)
        {
            EmployeeDto employee = this._employeesService.GetEmployeesByDocumentNumber(documentNumber);

            if (employee != null)
                return Ok(employee);

            return NotFound(new
            {
                Message = string.Format("No records were found for the document number: {0}", documentNumber)
            });
        }

    }
}
