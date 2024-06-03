import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { calculateDto } from './componentes/calculations/Dtos/calculateDto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'simulatorWeb';

  formulario!: FormGroup;
  constructor(private formBuilder: FormBuilder) { }

  calculateRequest: calculateDto = {

    applicationValue: '',
    numberOfMonths: ''
  }

}
