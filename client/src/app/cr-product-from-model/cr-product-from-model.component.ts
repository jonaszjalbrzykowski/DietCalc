import { Product } from './../_models/product';
import { Component, OnInit } from '@angular/core';
import { ProductModel } from '../_models/productModel';
import { ProductService } from '../_services/product.service';

@Component({
  selector: 'app-cr-product-from-model',
  templateUrl: './cr-product-from-model.component.html',
  styleUrls: ['./cr-product-from-model.component.css']
})
export class CrProductFromModelComponent implements OnInit {

  productModel: ProductModel;
  product: Product;
  product

  constructor(public productService: ProductService) {
    this.productModel = productService.getProductModel();
  }

  ngOnInit(): void {
  }

  addProduct(product: Product) {
    this.productService.addProductToDayMeal(product);
  }
}
