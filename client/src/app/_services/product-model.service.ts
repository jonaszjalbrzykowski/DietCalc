import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { ReplaySubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AddProductModelService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  addProductModel(model: any) {
    var address = this.baseUrl + 'productModel/add';
    return this.http.post(address, model);
  }
}
