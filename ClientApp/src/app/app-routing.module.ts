import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CustomerListComponent } from './customer/customer-list/customer-list.component';
import { CreateCustomerComponent } from './customer/create-customer/create-customer.component';
import { StatisticsListComponent } from './statistics/statistics-list/statistics-list.component';


const routes: Routes = [
  { path: "*", component: CustomerListComponent },
  { path: "", component: CustomerListComponent },
  { path: "customerList", component: CustomerListComponent },
  { path: "createCustomer", component: CreateCustomerComponent },
  { path: "statistics", component: StatisticsListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
