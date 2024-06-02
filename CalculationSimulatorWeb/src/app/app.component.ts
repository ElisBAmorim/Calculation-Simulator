import { Component } from '@angular/core';
import { calculateDto } from './componentes/calculations/calculateDto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'simulatorWeb';

  calculateRequest: calculateDto = {

    applicationValue: '1000',
    numberOfMonths: '6'
  }
}
