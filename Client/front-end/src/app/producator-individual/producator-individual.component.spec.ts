import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProducatorIndividualComponent } from './producator-individual.component';

describe('ProducatorIndividualComponent', () => {
  let component: ProducatorIndividualComponent;
  let fixture: ComponentFixture<ProducatorIndividualComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProducatorIndividualComponent]
    });
    fixture = TestBed.createComponent(ProducatorIndividualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
