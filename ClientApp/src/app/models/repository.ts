import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Customer } from './customer.model';
import { environment } from 'src/environments/environment.prod';

const customersUrl = "api/movies";

@Injectable({
    providedIn: 'root'
})
export class Repository {

    constructor(private http: HttpClient) {
      this.getCustomers();
    }

    getCustomers() {
        let url = environment.GetCustomers;
        
        this.http.get<any>(url)
            .subscribe(response => {                
                this.customers = response;                
            });
    }

    customers: Customer[] = [];    
}