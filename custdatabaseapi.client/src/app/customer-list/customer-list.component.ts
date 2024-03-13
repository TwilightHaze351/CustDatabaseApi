import { Component, OnInit, Type } from '@angular/core';
import { CustomerService } from '../services/customer.service';
import { Customer } from '../models/customer.model'; // Adjust the path as necessary

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent implements OnInit {
  customers: Customer[] = []; // Define the array to store customer data

  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
    this.loadCustomers();
  }

  loadCustomers(): void {
    this.customerService.getCustomers().subscribe({
      next: (data) => this.customers = data,
      error: (error) => console.error('There was an error!', error)
    });
  }
}
