import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-result-cdb',
  templateUrl: './result-cdb.component.html',
  styleUrls: ['./result-cdb.component.css']
})
export class ResultCdbComponent implements OnInit {

  @Input() result = {
    grossValue: 'R$:1.212,00',
    netValue: 'R$:952,33'
  }
  constructor() { }

  ngOnInit(): void {
  }

}
