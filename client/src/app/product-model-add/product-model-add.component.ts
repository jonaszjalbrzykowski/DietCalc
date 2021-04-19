import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AddProductModelService } from '../_services/product-model.service';

@Component({
  selector: 'app-product-model-add',
  templateUrl: './product-model-add.component.html',
  styleUrls: ['./product-model-add.component.css']
})
export class ProductModelAddComponent implements OnInit {

  model: any = {};

  constructor(public addProductModelService: AddProductModelService, private router: Router,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  addProductModel() {
     this.addProductModelService.addProductModel(this.model).subscribe(response => {
     this.router.navigateByUrl('/meal')
  })
  }

}
