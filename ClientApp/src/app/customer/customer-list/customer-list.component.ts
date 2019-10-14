import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/customer.model';
import { Repository } from 'src/app/models/repository';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {

  constructor(private repo: Repository) { }

  ngOnInit() {
  }

  get customers(): Customer[] {
    return this.repo.customers;
  }

}
