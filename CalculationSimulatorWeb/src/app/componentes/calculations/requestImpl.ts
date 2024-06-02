import { DecimalPipe } from "@angular/common";
import { StringToDecimalPipe } from "../../util/StringToDecimalPipe";
import { request } from "./request";

export class requestImpl implements request {
  numberOfMonths!: number;
  applicationValue!: number;


  constructor(numberOfMonths: string, applicationValue: string) {
    this.numberOfMonths = this.getValueDecimal(numberOfMonths);
    this.applicationValue = this.getValueDecimal(applicationValue);
  }

  getValueDecimal(value:string): number {
    const precoDecimal = new StringToDecimalPipe().transform(value);
    return precoDecimal;
  }

  toRequest(): request {
  return this;
  }
}
