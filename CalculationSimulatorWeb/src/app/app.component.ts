import { Component } from '@angular/core';
import { calculateRequest } from './componentes/calculations/calculateRequest';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'simulatorWeb';

  calculateRequest: calculateRequest = {

    applicationValue: '1000',
    numberOfMonths: '555'
  }
}
