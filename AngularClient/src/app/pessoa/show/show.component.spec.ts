import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowPessoaComponent } from './show.component';

describe('ShowPessoaComponent', () => {
  let component: ShowPessoaComponent;
  let fixture: ComponentFixture<ShowPessoaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowPessoaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowPessoaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
