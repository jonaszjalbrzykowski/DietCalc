import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AddProductService } from '../_services/add-product.service';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {

  model: any = {};

  constructor(public addProductService: AddProductService, private router: Router,
    private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  addProduct() {
     this.addProductService.addProduct(this.model).subscribe(response => {
      this.router.navigateByUrl('/meal')
  })
  }

}
