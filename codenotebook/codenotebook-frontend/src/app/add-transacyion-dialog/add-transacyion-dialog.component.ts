import { CurrencyPipe } from '@angular/common';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Transaction, TransactionCategory } from '../../models/transaction';
import { TransactionService } from '../transaction.service';
import { DatePipe } from '@angular/common';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-add-transacyion-dialog',
  templateUrl: './add-transacyion-dialog.component.html',
  styleUrls: ['./add-transacyion-dialog.component.css']
})
export class AddTransacyionDialogComponent implements OnInit {

  eTransactionCategory = ["Food And Household Chemistry",
    "Crossings",
    "Influences",
    "Accessories & Equipment",
    "Eating Out",
    "Uncategorized",
    'Outings And Events',
    'Current',
    'Gifts And Support',
    'Renumeration' ,
    'Regular Saving',
    'Flue',
    'Renovation And Garden',
    'Multimedia,Books and Press',
    'Clothing & Footwear' ,
    'Tv,Internet,Telephone'];
  form!: FormGroup;
  description: FormControl;
  type!: FormControl;
  amount!: FormControl;
  amount1!: string;
  dateTime!: Date;
description1!: string;
    roomsFilter: any;
  constructor(
    private transactionService : TransactionService,
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<AddTransacyionDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any, private currencyPipe: CurrencyPipe, public datepipe: DatePipe) {


    this.form = this.fb.group({
      type: [null, [Validators.required]],
      description: [null, [Validators.required]],
    });

    this.type = this.form.controls['type'] as FormControl;
    this.description = this.form.controls['description'] as FormControl;
    this.amount = this.form.controls['amount'] as FormControl;
  }

  ngOnInit() {

    this.form = this.fb.group({
      description: [this.description, []]
        });
  }

  add() {
    var description = this.description1;
    var type = (<any>TransactionCategory)[this.type.value];
    var amount = Number(this.amount1);
    let currentDateTime = this.datepipe.transform(this.dateTime, 'yyyy-MM-dd');
    var transaction = new Transaction(currentDateTime ? currentDateTime : '', description, type, amount);
    this.transactionService.addTransaction(transaction);
    this.dialogRef.close(this.form.value)
  }


  close() {
    this.dialogRef.close();
  }
}
