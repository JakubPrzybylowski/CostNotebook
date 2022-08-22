import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { TransactionService } from '../transaction.service';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { ToastrService } from 'ngx-toastr';
import { User } from '../../models/user';
import { Transaction, TransactionCategory } from '../../models/transaction';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { AddTransacyionDialogComponent } from '../add-transacyion-dialog/add-transacyion-dialog.component';

@Component({
  selector: 'app-bills',
  templateUrl: './transactions.component.html',
  styleUrls: ['./transactions.component.css']
})
export class TransactionsComponent implements OnInit {
  TransactionCategory = TransactionCategory;
  TransactionList?: Observable<Transaction[]>;
  TransactionList1?: Observable<Transaction[]>;
  UserList2?: Transaction[];
  productForm: any;
  massage = "";
  prodCategory = "";
  productId = 0;
  searchTerm = '';  
  public searchFilter: any = '';
  constructor(private formbulider: FormBuilder,
    private transactionService: TransactionService, private router: Router,
    private jwtHelper: JwtHelperService, private toastr: ToastrService, private dialog: MatDialog) { }

  ngOnChanges() {
    this.getProductList();
  }
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
    this.transactionService.getUserList();
    this.TransactionList1 = this.transactionService.transactions;
    this.TransactionList = this.TransactionList1;
  }

  openDialog() {
    const dialogConfig = new MatDialogConfig();

    dialogConfig.disableClose = true;
    dialogConfig.autoFocus = true;

    this.dialog.open(AddTransacyionDialogComponent, dialogConfig).afterClosed().subscribe(() => this.getProductList());
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
