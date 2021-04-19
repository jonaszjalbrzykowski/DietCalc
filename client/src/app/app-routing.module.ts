import { ProductAddComponent } from './product-add/product-add.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { AuthGuard } from './_guards/auth.guard';
import { DaymealComponent } from './daymeal/daymeal.component';
import { MealComponent } from './meal/meal.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductModelAddComponent } from './product-model-add/product-model-add.component';

const routes: Routes = [
  {path: '', component: HomeComponent },
  {
    path:'',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'product', component: ProductModelAddComponent, canActivate: [AuthGuard] },
      {path: 'meal', component: MealComponent },
      {path: 'daymeal', component: DaymealComponent },
      {path: 'product-add', component: ProductAddComponent },


    ]
  },
  {path:'errors', component: TestErrorsComponent},
  {path:'not-found', component: NotFoundComponent},
  {path:'server-error', component: ServerErrorComponent},
  {path: '**', component: NotFoundComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
