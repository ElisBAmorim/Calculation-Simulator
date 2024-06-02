import { AbstractControl } from "@angular/forms";

export function valuePositiveValidator(control: AbstractControl) {

  if (control.value === '') {
    return false;
  }
  else {
    const value = control.value as number;
    if (value < 0) {
      return { positive: true };
    }

    return false
  }
}

export function valueAboveTwoValidator(control: AbstractControl) {

  if (control.value === '') {
    return false;
  }
  else {
    const value = control.value as number;
    if (value <= 1) {
      return { aboveTwo: true };
    }

    return false
  }
}
