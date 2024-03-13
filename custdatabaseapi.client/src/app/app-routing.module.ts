import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerListComponent } from './customer-list/customer-list.component';

const routes: Routes = [
  { path: 'customers', component: CustomerListComponent },
  { path: '', redirectTo: '/customers', pathMatch: 'full' }, // Redirects to /customers as the default route
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
