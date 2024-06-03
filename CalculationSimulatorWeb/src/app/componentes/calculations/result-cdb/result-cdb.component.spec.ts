import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResultCdbComponent } from './result-cdb.component';

describe('ResultCdbComponent', () => {
  let component: ResultCdbComponent;
  let fixture: ComponentFixture<ResultCdbComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ResultCdbComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ResultCdbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
