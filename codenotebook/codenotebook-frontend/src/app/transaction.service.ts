import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import {environment } from '../environments/environment'
import { Transaction } from '../models/transaction';
import { User } from '../models/user';
import { AuthGuard } from './authguard.service';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private _users = new BehaviorSubject<Transaction[]>([]);
  private dataStore: { users: Transaction[] } = { users: [] };
  readonly transactions = this._users.asObservable();
  url = 'https://localhost:5001/api/transactions';
  userId = this.authguardService.getUser().id;
  constructor(private http: HttpClient, private authguardService: AuthGuard) { }
  getUserList() {

    let token = localStorage.getItem('jwt');
    if (token != null)
    {
      let decodedJWT = JSON.parse(window.atob(token.split('.')[1]));
 
      let email = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
      const header = new HttpHeaders().set('Authorization', 'Bearer' + localStorage.getItem('jwt'));
      let params = new HttpParams().set("userId", this.userId);
      this.http.get<Transaction[]>(this.url, { headers: header, params: params }).subscribe(data => {
        this.dataStore.users = data;
        this._users.next(Object.assign({}, this.dataStore).users);
      },
        error => console.log('Could not load transactions.'));
    }
  }

  addTransaction(transaction: Transaction) {
    let token = localStorage.getItem('jwt');
    if (token != null) {
      let decodedJWT = JSON.parse(window.atob(token.split('.')[1]));


      let email = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
      const transactionJson = JSON.stringify(transaction)
      const header = new HttpHeaders().set('Authorization', 'Bearer' + localStorage.getItem('jwt')).set('Content-Type', 'application/json; charset=utf-8');
      let params = new HttpParams().set("userId", this.userId);
      this.http.post(this.url, transactionJson, { headers: header, params: params }).subscribe(_ => {
        this.dataStore.users.push(transaction);
        this._users.next(Object.assign({}, this.dataStore).users);
      },
        error => console.log('Could not load transactions.'));
    }
  }
  getTotalPositiveAmounts() {
    return this.http.get<number[]>('https://localhost:5001/api/transactions/api/transactions/positiveAmounts')
  }
  getTotalNegativeAmounts() {
    return this.http.get<number[]>('https://localhost:5001/api/transactions/api/transactions/negativeAmounts')
  }
  GtTransactionsByCatergory() {
    return this.http.get<number[]>('https://localhost:5001/api/transactions/api/transactions/category')
  }

  }
