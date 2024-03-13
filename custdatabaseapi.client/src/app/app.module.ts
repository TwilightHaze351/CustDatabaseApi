import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerListComponent } from './customer-list/customer-list.component'; // Ensure this path matches where your component file is

@NgModule({
  declarations: [
    AppComponent,
    CustomerListComponent // Add your component here
  ],
  imports: [
    BrowserModule,
    HttpClientModule, // Ensure HttpClientModule is here for HTTP operations
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
