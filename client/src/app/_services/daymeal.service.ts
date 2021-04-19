import { Meal } from '../_models/meal';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class DaymealService {
  baseUrl = 'https://localhost:5001/api/';
  meals : Array<Meal>;


  constructor(private http: HttpClient) {
    this.meals = new Array();
  }

  generateMeal() {
    var meal = new Meal();
    this.meals.push(meal);
  }
}
