import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { response } from '../Interface/response';

@Component({
  selector: 'app-result-cdb',
  templateUrl: './result-cdb.component.html',
  styleUrls: ['./result-cdb.component.css']
})
export class ResultCdbComponent implements OnInit {

  @Input() resultEx: response = {
    grossValue: 'R$:1.212,00',
    netValue: 'R$:952,33'
  }

  @Input() result: response = {
    grossValue: 'R$:',
    netValue: 'R$:'
  }
  constructor(private _router: ActivatedRoute) {

  }

  ngOnInit(): void {

    this.result.grossValue += (this._router.snapshot.paramMap.get('grossValue'));
    this.result.netValue += (this._router.snapshot.paramMap.get('netValue'));
  }

}
