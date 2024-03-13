import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'] // Note: This was corrected from 'styleUrl' to 'styleUrls'
})
export class AppComponent {
  title = 'custdatabaseapi.client';

  constructor() { }

  ngOnInit() {
    // Initialization logic can go here
  }
}
