import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddTransacyionDialogComponent } from './add-transacyion-dialog.component';

describe('AddTransacyionDialogComponent', () => {
  let component: AddTransacyionDialogComponent;
  let fixture: ComponentFixture<AddTransacyionDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddTransacyionDialogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddTransacyionDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
