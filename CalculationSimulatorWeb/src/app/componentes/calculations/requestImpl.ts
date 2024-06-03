import { DecimalPipe } from "@angular/common";
import { StringToDecimalPipe } from "../../util/StringToDecimalPipe";
import { request } from "./request";

export class requestImpl implements request {
  numberOfMonths!: number;
  applicationValue!: number;


  constructor(numberOfMonths: string, applicationValue: string) {
    this.numberOfMonths = this.getValueMes(numberOfMonths); 
    
    this.applicationValue = this.getValueMoney(applicationValue);
  }

  getValueMoney(value:string): number { 
    return parseFloat(value);
  }
  getValueMes(value: string): number {
    return parseInt(value);
  }

  toRequest(): request {
  return this;
  }
}

