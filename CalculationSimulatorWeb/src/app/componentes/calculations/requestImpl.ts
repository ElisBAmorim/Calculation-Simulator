import { DecimalPipe } from "@angular/common";
import { StringToDecimalPipe } from "../../util/StringToDecimalPipe";
import { request } from "./request";

export class requestImpl implements request {
  numberOfMonths!: DecimalPipe;
  applicationValue!: DecimalPipe;


  constructor(numberOfMonths: string, applicationValue: string) {

  }

  getPrecoDecimal(value:string): number {
    const precoDecimal = new StringToDecimalPipe().transform(value);
    return precoDecimal;
  }

}
