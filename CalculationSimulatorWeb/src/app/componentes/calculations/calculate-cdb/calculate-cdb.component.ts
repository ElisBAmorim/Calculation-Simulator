import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculate-cdb',
  templateUrl: './calculate-cdb.component.html',
  styleUrls: ['./calculate-cdb.component.css']
})
export class CalculateCdbComponent implements OnInit {

  //calculateCdb = {
  //  id: '1',
  //  applicationValue:'10202',
  //  numberOfMonths:'tsetre'
  //}

  constructor() { }

  ngOnInit(): void {
  }

  calculateCDB() {
    alert("calcular");
  }

  clearFields() {
    alert("limpar");
  }
}
