import { Component, Input, OnInit } from '@angular/core';
import { CalculateServiceService } from '../calculate-service.service';
import { calculateDto } from '../calculateDto';


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


  constructor(private CalculateServiceService: CalculateServiceService) { }

  ngOnInit(): void {
  }

  calculateCDB(calculate: calculateDto) {
    alert(calculate.applicationValue);
  }

  clearFields() {
    alert("limpar");
  }
}
