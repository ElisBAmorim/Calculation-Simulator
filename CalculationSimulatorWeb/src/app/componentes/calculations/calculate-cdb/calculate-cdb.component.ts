import { Component, Input, OnInit } from '@angular/core';
import { CalculateServiceService } from '../calculate-service.service';
import { calculateDto } from '../calculateDto';
import { requestImpl } from '../requestImpl';
import { response } from '../response';


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


  constructor(private service: CalculateServiceService) { }

  ngOnInit(): void {
  }


  calculateCDB(calculate: calculateDto) {
    alert("Entrou -> : " +calculate.applicationValue);
    const reqImpl = new requestImpl(calculate.numberOfMonths, calculate.applicationValue);
    const req = reqImpl.toRequest();  

    this.service.post(req).subscribe((resp: response) => {
      alert("res -> grossValue: " + resp.grossValue + " netValue:" + resp.netValue);

    });
  

  }

  clearFields() {
    alert("limpar");
  }
}
