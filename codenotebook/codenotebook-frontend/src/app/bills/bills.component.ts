import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { BillService } from '../bill.service';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { ToastrService } from 'ngx-toastr';
import { User } from '../../models/user';

@Component({
  selector: 'app-bills',
  templateUrl: './bills.component.html',
  styleUrls: ['./bills.component.css']
})
export class BillsComponent implements OnInit {

  UserList?: Observable<User[]>;
  UserList1?: Observable<User[]>;
  UserList2?: User[];
  productForm: any;
  massage = "";
  prodCategory = "";
  productId = 0;
  searchTerm = '';  
  public searchFilter: any = '';
  constructor(private formbulider: FormBuilder,
    private billService: BillService, private router: Router,
    private jwtHelper: JwtHelperService, private toastr: ToastrService) { }

  ngOnInit() {
    this.prodCategory = "0";
    this.productForm = this.formbulider.group({
      productName: ['', [Validators.required]],
      productCost: ['', [Validators.required]],
      productDescription: ['', [Validators.required]],
      productStock: ['', [Validators.required]]
    });
    this.getProductList();
  }
  getProductList() {
    this.billService.getUserList();
    this.UserList1 = this.billService.users;
    this.UserList = this.UserList1;
  }
  //PostProduct(user: User) {
  //  const product_Master = this.productForm.value;
  //  this.productService.postProductData(product_Master).subscribe(
  //    () => {
  //      this.getProductList();
  //      this.productForm.reset();
  //      this.toastr.success('Data Saved Successfully');
  //    }
  //  );
  //}
  //ProductDetailsToEdit(id: string) {
  //  this.productService.getProductDetailsById(id).subscribe(productResult => {
  //    this.productId = productResult.productId;
  //    this.productForm.controls['productName'].setValue(productResult.productName);
  //    this.productForm.controls['productCost'].setValue(productResult.productCost);
  //    this.productForm.controls['productDescription'].setValue(productResult.productDescription);
  //    this.productForm.controls['productStock'].setValue(productResult.productStock);
  //  });
  //}
  //UpdateProduct(product: Products) {
  //  product.productId = this.productId;
  //  const product_Master = this.productForm.value;
  //  this.productService.updateProduct(product_Master).subscribe(() => {
  //    this.toastr.success('Data Updated Successfully');
  //    this.productForm.reset();
  //    this.getProductList();
  //  });
  //}

  //DeleteProduct(id: number) {
  //  if (confirm('Do you want to delete this product?')) {
  //    this.productService.deleteProductById(id).subscribe(() => {
  //      this.toastr.success('Data Deleted Successfully');
  //      this.getProductList();
  //    });
  //  }
  //}

  //Clear(product: Products) {
  //  this.productForm.reset();
  //}

  public logOut = () => {
    localStorage.removeItem("jwt");
    this.router.navigate(["/"]);
  }

  isUserAuthenticated() {
    const token = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    }
    else {
      return false;
    }
  }
}
