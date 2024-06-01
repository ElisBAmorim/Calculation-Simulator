import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculate-cdb',
  templateUrl: './calculate-cdb.component.html',
  styleUrls: ['./calculate-cdb.component.css']
})
export class CalculateCdbComponent implements OnInit {

  calculateCdb = {
    id: '1',
    grossValue: 'R$:1000,00',
    netValue: 'R$:958,33'
  }


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
