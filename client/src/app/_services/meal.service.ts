import { Product } from './../_models/product';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MealService {

  baseUrl = 'https://localhost:5001/api/';
  products : Array<Product>;

  addProduct() {
    var product = new Product();
    this.products.push(product);
  }

  constructor() { }
}
