import { ProductModel } from './../_models/productModel';
import { Product } from '../_models/product';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Observable, ReplaySubject } from 'rxjs';
import { User } from '../_models/user';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  baseUrl : string = 'https://localhost:5001/api/';
  products : Array<object>;
  productModel: ProductModel;

  constructor(private http: HttpClient) {
   }

  getProducts() {
        return this.http.get<ProductModel[]>(this.baseUrl + 'productModel');
  }

  getProductModel() {
    return this.productModel;
  }

  setProductModel(model: ProductModel) {
    this.productModel = model;
  }

    addProduct(model: any) {
  }

  addProductModel(model: any) {
    var address = this.baseUrl + 'productModel/add';
    return this.http.post(address, model);
  }

  addProductToDayMeal(model: any) {
    
  }


}
