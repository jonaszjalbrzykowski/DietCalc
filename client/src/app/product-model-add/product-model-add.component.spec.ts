import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductModelAddComponent } from './product-model-add.component';

describe('ProductModelAddComponent', () => {
  let component: ProductModelAddComponent;
  let fixture: ComponentFixture<ProductModelAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductModelAddComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductModelAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
