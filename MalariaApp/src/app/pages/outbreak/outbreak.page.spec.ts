import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OutbreakPage } from './outbreak.page';

describe('OutbreakPage', () => {
  let component: OutbreakPage;
  let fixture: ComponentFixture<OutbreakPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OutbreakPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OutbreakPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
