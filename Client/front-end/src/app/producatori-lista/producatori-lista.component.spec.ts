import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProducatoriListaComponent } from './producatori-lista.component';

describe('ProducatoriListaComponent', () => {
  let component: ProducatoriListaComponent;
  let fixture: ComponentFixture<ProducatoriListaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProducatoriListaComponent]
    });
    fixture = TestBed.createComponent(ProducatoriListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
