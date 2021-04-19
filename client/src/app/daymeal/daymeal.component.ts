import { DaymealService } from '../_services/daymeal.service';
import { Component, OnInit } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Router } from '@angular/router';
import { Meal } from '../_models/meal';

@Component({
  selector: 'app-daymeal',
  templateUrl: './daymeal.component.html',
  styleUrls: ['./daymeal.component.css']
})
export class DaymealComponent implements OnInit {

  model: any = {};
  meals : Array<Meal>;

  constructor(public daymealService: DaymealService, private router: Router) {
      this.meals = daymealService.meals
  }


  ngOnInit(): void {
  }

  saveMeal() {
  }

  generateMeal() {
    this.daymealService.generateMeal();
  }
}
