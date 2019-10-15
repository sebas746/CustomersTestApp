import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Repository } from 'src/app/models/repository';
import { Country } from 'src/app/models/country.model';
import { State } from 'src/app/models/state.model';
import { City } from 'src/app/models/city.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-customer',
  templateUrl: './create-customer.component.html',
  styleUrls: ['./create-customer.component.css']
})
export class CreateCustomerComponent implements OnInit {
  customerForm: FormGroup;
  isSubmitted = false;

  constructor(private formBuilder: FormBuilder, private repo: Repository, private router: Router) {

  }

  ngOnInit() {
    this.createForm();
  }

  get countries(): Country[] {
    return this.repo.countries;
  }

  get states(): State[] {
    return this.repo.states;
  }

  get cities(): City[] {
    return this.repo.cities;
  }

  get form() { return this.customerForm.controls; }

  onCountryChange() {
    if(this.customerForm.get('country').value.CountryId != undefined) {
      this.repo.getCountryStates(this.customerForm.get('country').value.CountryId);
      this.customerForm.get('state').enable();
    }
  }

  onStateChange() {
    if(this.customerForm.get('state').value.StateId != undefined) {
      this.repo.getStateCities(this.customerForm.get('state').value.StateId);
      this.customerForm.get('city').enable();
    }
  }

  createForm() {
    this.customerForm = this.formBuilder.group({
      nit: [null, Validators.required],
      fullName: [null, Validators.required],
      address: [null, Validators.required],
      phone: [null, Validators.required],
      country: [null, Validators.required],
      state: [{value:null, disabled: true}, Validators.required],
      city: [{value:null, disabled: true}, Validators.required],
      creditLimit: [null, Validators.required]
    });
  }

  submit() {
    this.isSubmitted = true;

    if(this.customerForm.invalid) {
      return;
    }

    this.repo.createCustomer(this.customerForm);
    this.router.navigate([""]);
  }
}
