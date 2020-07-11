import { Injectable } from '@angular/core';
import { Employee } from '../employees/interfaces/employee.interface';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})

export class EmployeesService {

  private employees: Employee[] = [];

    constructor( private http: HttpClient) {
    }

    public getEmployees(): any {
      return this.http.get('https://localhost:44314/api/Employees');
    }

    public getEmployee(document: string): any {
      return this.http.get('https://localhost:44314/api/Employees/' + document);
    }

}

