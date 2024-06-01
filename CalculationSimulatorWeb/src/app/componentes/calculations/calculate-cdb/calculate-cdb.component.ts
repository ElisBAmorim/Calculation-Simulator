import { Component, Input, OnInit } from '@angular/core';
import { CalculateServiceService } from '../calculate-service.service';
import { calculateRequest } from '../calculateRequest';

@Component({
  selector: 'app-calculate-cdb',
  templateUrl: './calculate-cdb.component.html',
  styleUrls: ['./calculate-cdb.component.css']
})
export class CalculateCdbComponent implements OnInit {

  @Input() calculateCdb: calculateRequest = {

    applicationValue: '',
    numberOfMonths: ''
  }


  constructor(private CalculateServiceService: CalculateServiceService) { }

  ngOnInit(): void {
  }

  calculateCDB(calculate: calculateRequest) {
    alert(calculate.applicationValue);
  }

  clearFields() {
    alert("limpar");
  }
}
