import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActiveAreaPage } from './active-area.page';

describe('ActiveAreaPage', () => {
  let component: ActiveAreaPage;
  let fixture: ComponentFixture<ActiveAreaPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActiveAreaPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActiveAreaPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
