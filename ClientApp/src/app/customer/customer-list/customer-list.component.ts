import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/customer.model';
import { Repository } from 'src/app/models/repository';
import { faSearch } from '@fortawesome/free-solid-svg-icons';
import { faTrash } from '@fortawesome/free-solid-svg-icons';
import { faPen } from '@fortawesome/free-solid-svg-icons';
import { faPlus } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {
  faSearch = faSearch;
  faTrash = faTrash;
  faPen = faPen;
  faPlus = faPlus;

  constructor(private repo: Repository) { }

  ngOnInit() {
  }

  get customers(): Customer[] {
    return this.repo.customers;
  }
}
