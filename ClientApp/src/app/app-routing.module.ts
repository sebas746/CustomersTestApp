import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CustomerListComponent } from './customer/customer-list/customer-list.component';
import { CreateCustomerComponent } from './customer/create-customer/create-customer.component';


const routes: Routes = [
  { path: "*", component: CustomerListComponent },
  { path: "", component: CustomerListComponent },
  { path: "customerList", component: CustomerListComponent },
  { path: "createCustomer", component: CreateCustomerComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
