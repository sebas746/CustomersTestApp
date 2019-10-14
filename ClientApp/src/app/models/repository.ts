import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { keyframes } from '@angular/animations';
import { Customer } from './customer.model';

const customersUrl = "api/movies";

@Injectable({
    providedIn: 'root'
})
export class Repository {

    constructor(private http: HttpClient) {
      
    }

    getMovies() {
        let url = customersUrl;
      
        this.http.get<any>(url)
            .subscribe(response => {                
                this.customers = response.data;
            });
    }

    customers: Customer[] = [];    
}