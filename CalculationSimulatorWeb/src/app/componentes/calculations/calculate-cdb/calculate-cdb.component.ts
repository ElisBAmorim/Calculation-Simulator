import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { calculateDto } from '../Dtos/calculateDto';
import { requestImpl } from '../Interface/Impl/requestImpl';
import { response } from '../Interface/response';
import { CalculateServiceService } from '../Service/calculate-service.service';
import { valueAboveTwoValidator, valuePositiveValidator } from '../Validator/FieldsValidator';

@Component({
  selector: 'app-calculate-cdb',
  templateUrl: './calculate-cdb.component.html',
  styleUrls: ['./calculate-cdb.component.css']
})
export class CalculateCdbComponent implements OnInit {
   
  isValidInterge: boolean = true;
  isValidVirgula: boolean = true;


  @Input() calculateCdb: calculateDto = {

    applicationValue: '',
    numberOfMonths: ''
  }

  formulario!: FormGroup;

  constructor(private service: CalculateServiceService,
    private router: Router,
    private formBuilder: FormBuilder) { }

  
  validateVirgula(event: KeyboardEvent): void {
    const value = event['key'];
    
    this.isValidVirgula = /^-?\d+$/.test(value);
  }

  validateInteger(event: Event): void {
    const input = event.target as HTMLInputElement;
    const value = input.value;

    this.isValidInterge = /^-?\d+$/.test(value);
  }
    

  ngOnInit(): void {
    this.formulario = this.formBuilder.group({
      applicationValue: ['', [Validators.required, valuePositiveValidator]],
      numberOfMonths: ['', [Validators.required, valueAboveTwoValidator]],
    });
  }


  calculateCDB(calculate: calculateDto) {  
    const reqImpl = new requestImpl(calculate.numberOfMonths, calculate.applicationValue);
    const req = reqImpl.toRequest();  

    this.service.post(req).subscribe((resp: response) => {     
      this.router.navigate(['/resultado-cdb', resp.grossValue, resp.netValue]);
    });  
  }
  
}
