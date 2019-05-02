import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SymptonComponent } from './sympton.component';

describe('SymptonComponent', () => {
  let component: SymptonComponent;
  let fixture: ComponentFixture<SymptonComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SymptonComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SymptonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
