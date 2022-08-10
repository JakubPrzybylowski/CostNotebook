import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import {environment } from '../environments/environment'
import { Transaction } from '../models/transaction';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private _transactions = new BehaviorSubject<Transaction[]>([]);
  private dataStore: { transactions: Transaction[] } = { transactions: [] };
  readonly transactions = this._transactions.asObservable();
  url = 'https://localhost:5001/transactions';
  constructor(private http: HttpClient) { }
  getUserList() {
    const header = new HttpHeaders().set('Authorization', 'Bearer' + localStorage.getItem('jwt'));
    let params = new HttpParams().set("userId", 4);
    this.http.get<Transaction[]>(this.url + '/4', {headers: header}).subscribe(data => {
      this.dataStore.transactions = data;
      this._transactions.next(Object.assign({}, this.dataStore).transactions);
    },
      error => console.log('Could not load transactions.'));
  }

}
