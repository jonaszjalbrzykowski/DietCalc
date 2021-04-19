import { AddProductService } from '../_services/product.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from '../_models/product';


@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {
  products: Product[];
  searchText : string = "win";


  constructor(public addProductService: AddProductService, public router: Router) {
      this.getProducts();

   }

  ngOnInit(): void {
  }

  getProducts() {
    this.addProductService.getProducts().subscribe(products => {
      this.products = products;
    });
  }

}
