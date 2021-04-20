import { ProductModel } from './../_models/productModel';
import { Product } from './../_models/product';
import { ProductService } from '../_services/product.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {

  pageTitle: string = 'Product List';
  errorMessage: string;
  filteredProducts: ProductModel[];
  products: ProductModel[];
  _listFilter: string;

  get listFilter(): string
    { return this._listFilter; }
    set listFilter(value: string)
    { this._listFilter = value;
    this.filteredProducts = this.listFilter ? this.performFilter(this.listFilter) : this.products; }


  constructor(public productService: ProductService, public router: Router) {
      this.getProducts();
   }

   performFilter(filterBy: string): ProductModel[] {
    filterBy = filterBy.toLocaleLowerCase();
    return this.products.filter((product: ProductModel) =>
    product.name.toLocaleLowerCase().indexOf(filterBy) !== -1); }

  ngOnInit(): void {
  }

  CreateProductFromModel(productModel: ProductModel) {
      this.router.navigateByUrl("/create-product")
  }


  getProducts() {
    this.productService.getProducts().subscribe(products => {
      this.products = products;
    })
  }
  }


