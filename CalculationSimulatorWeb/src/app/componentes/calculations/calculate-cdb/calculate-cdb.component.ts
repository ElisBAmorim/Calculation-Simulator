import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CalculateServiceService } from '../calculate-service.service';
import { calculateDto } from '../calculateDto';
import { requestImpl } from '../requestImpl';
import { response } from '../response';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Validators } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { valuePositiveValidator } from '../Validator/FieldsValidator';

@Component({
  selector: 'app-calculate-cdb',
  templateUrl: './calculate-cdb.component.html',
  styleUrls: ['./calculate-cdb.component.css']
})
export class CalculateCdbComponent implements OnInit {

  @Input() calculateCdb: calculateDto = {

    applicationValue: '',
    numberOfMonths: ''
  }

  formulario!: FormGroup;

  constructor(private service: CalculateServiceService,
    private router: Router,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.formulario = this.formBuilder.group({
      applicationValue: ['', [Validators.required, valuePositiveValidator]],
      numberOfMonths: ['', [Validators.required]],
    });
  }


  calculateCDB(calculate: calculateDto) {  
    const reqImpl = new requestImpl(calculate.numberOfMonths, calculate.applicationValue);
    const req = reqImpl.toRequest();  

    this.service.post(req).subscribe((resp: response) => {     
      this.router.navigate(['/resultado-cdb', resp.grossValue, resp.netValue]);
    });  
  }

  responseCdb: response = {
    grossValue: '1525',
    netValue: '666'
  }

  testeFields(responseResult: response) {  
    this.router.navigate(['/resultado-cdb', responseResult.grossValue, responseResult.netValue]);
  }
}
