import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubtypePage } from './subtype.page';

describe('SubtypePage', () => {
  let component: SubtypePage;
  let fixture: ComponentFixture<SubtypePage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubtypePage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubtypePage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
