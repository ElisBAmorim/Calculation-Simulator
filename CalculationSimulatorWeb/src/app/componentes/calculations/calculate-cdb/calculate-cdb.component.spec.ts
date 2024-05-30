import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CalculateCdbComponent } from './calculate-cdb.component';

describe('CalculateCdbComponent', () => {
  let component: CalculateCdbComponent;
  let fixture: ComponentFixture<CalculateCdbComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CalculateCdbComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CalculateCdbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
