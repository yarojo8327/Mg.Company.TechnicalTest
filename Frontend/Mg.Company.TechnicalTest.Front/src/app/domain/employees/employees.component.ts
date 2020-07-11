import { Component, OnInit } from '@angular/core';
import {EmployeesService} from '../employees/employees.service';
import { Employee } from '../employees/interfaces/employee.interface';


@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html'
})

export class EmployeesComponent implements OnInit {

  employees: Employee[] = [];
  errorMessage: string = '';

  constructor( private employeeServices: EmployeesService) {
  }

  ngOnInit(): void {
    this.getEmployees();
  }


  getEmployeesFilter(document: string){
    this.errorMessage = '';
    if (document == null || document === '' || document === undefined){
      this.getEmployees();
    }else{
      this.employees = [];
      console.log(document);
      this.getEmployee(document);
    }
  }


  private getEmployees(): any {
      this.employeeServices.getEmployees().subscribe( (resp: Employee[]) => {
        this.errorMessage = '';
        this.employees = resp;
      });
  }

  private getEmployee(document: string) {
    this.employeeServices.getEmployee(document).subscribe((resp: Employee) => {
      if (resp != null){
        this.employees.push(resp);
      }
    }, error => {
      this.errorMessage = error.error.message;
    });
  }
}
