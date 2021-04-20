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

  constructor(private http: HttpClient) {
   }

  getProducts() {
        return this.http.get<ProductModel[]>(this.baseUrl + 'productModel');
  }

    addProduct(model: any) {
  }
}
