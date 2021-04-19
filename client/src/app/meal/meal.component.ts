import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MealService } from '../_services/meal.service';

@Component({
  selector: 'app-meal',
  templateUrl: './meal.component.html',
  styleUrls: ['./meal.component.css']
})
export class MealComponent implements OnInit {

  constructor(public mealService: MealService, public router: Router) { }

  ngOnInit(): void {
  }

  addProduct() {
    this.mealService.addProduct();
  }

}
