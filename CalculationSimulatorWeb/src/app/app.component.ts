import { Component } from '@angular/core';
import { calculateDto } from './componentes/calculations/calculateDto';
import { response } from './componentes/calculations/response';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'simulatorWeb';

  calculateRequest: calculateDto = {

    applicationValue: '',
    numberOfMonths: ''
  }

}
