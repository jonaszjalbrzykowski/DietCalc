import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { ReplaySubject } from 'rxjs';
import { User } from './../_models/user';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AddProductService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  addProduct(model: any) {
    return this.http.post(this.baseUrl + 'product/add', model)
  }
}
