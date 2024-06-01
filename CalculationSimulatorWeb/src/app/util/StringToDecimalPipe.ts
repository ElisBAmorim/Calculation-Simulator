// string-to-decimal.pipe.ts
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'stringToDecimal'
})
export class StringToDecimalPipe implements PipeTransform {
  transform(value: string): number {
    // Remova qualquer caractere não numérico (como vírgulas ou pontos)
    const cleanedValue = value.replace(/[^0-9.-]/g, '');

    // Converta o valor formatado de volta para um número decimal
    return parseFloat(cleanedValue);
  }
}
