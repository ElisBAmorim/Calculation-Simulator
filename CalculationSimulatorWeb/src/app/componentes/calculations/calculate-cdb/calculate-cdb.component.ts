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

  integerValue: number | null = null;
  isValidInterge: boolean = true;

  @Input() calculateCdb: calculateDto = {

    applicationValue: '',
    numberOfMonths: ''
  }

  formulario!: FormGroup;

  constructor(private service: CalculateServiceService,
    private router: Router,
    private formBuilder: FormBuilder) { }


  validateInteger(event: KeyboardEvent): void {
    const value = event['key'];

    this.isValidInterge = /^-?\d+$/.test(value);

    if (!this.isValidInterge) {
      this.integerValue = null;
    }
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
