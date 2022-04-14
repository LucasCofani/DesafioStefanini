import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCidadeComponent } from './edit.component';

describe('EditCidadeComponent', () => {
  let component: EditCidadeComponent;
  let fixture: ComponentFixture<EditCidadeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditCidadeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditCidadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
