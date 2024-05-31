import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculationResultComponent } from './calculation-result.component';

describe('CalculationResultComponent', () => {
  let component: CalculationResultComponent;
  let fixture: ComponentFixture<CalculationResultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CalculationResultComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CalculationResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
