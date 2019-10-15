import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Customer } from './customer.model';
import { environment } from 'src/environments/environment.prod';
import { Country } from './country.model';
import { State } from './state.model';
import { City } from './city.model';
import { FormGroup } from '@angular/forms';

const customersUrl = "api/movies";

@Injectable({
    providedIn: 'root'
})
export class Repository {

    constructor(private http: HttpClient) {
        this.getCustomers();
        this.getCountries();
    }

    getCustomers() {
        let url = environment.GetCustomers;
        this.http.get<any>(url)
            .subscribe(response => {
                this.customers = response;
            });
    }

    getCountries() {
        let url = environment.GetCountries;
        this.http.get<any>(url)
            .subscribe(response => {
                this.countries = response;
            });
    }

    getCountryStates(countryId: number) {
        let url = environment.GetStates + countryId;
        this.http.get<any>(url)
            .subscribe(response => {
                this.states = response;
            });
    }

    getStateCities(stateId: number) {
        let url = environment.GetCities + stateId;
        this.http.get<any>(url)
            .subscribe(response => {
                this.cities = response;
            });
    }

    createCustomer(customerForm: FormGroup) {
        let url = environment.CreateCustomer;        
        let customer:Customer = {
            address : customerForm.get('address').value,
            cityId : customerForm.get('city').value.CityId,
            countryId : customerForm.get('country').value.CountryId,
            fullName : customerForm.get('fullName').value,
            nit : customerForm.get('nit').value,
            phone : customerForm.get('phone').value,
            stateId : customerForm.get('state').value.StateId,
            creditLimit: customerForm.get('creditLimit').value,
        }

        this.http.post<number>(url, customer)
            .subscribe(response => {
               console.log(response);
               this.getCustomers();
            });
    }

    customers: Customer[] = [];
    countries: Country[] = [];
    states: State[] = [];
    cities: City[] = [];
}