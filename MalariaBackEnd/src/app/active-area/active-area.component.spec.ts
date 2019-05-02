import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActiveAreaComponent } from './active-area.component';

describe('ActiveAreaComponent', () => {
  let component: ActiveAreaComponent;
  let fixture: ComponentFixture<ActiveAreaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActiveAreaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActiveAreaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
