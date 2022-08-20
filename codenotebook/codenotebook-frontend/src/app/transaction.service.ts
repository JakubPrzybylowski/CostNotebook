import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import {environment } from '../environments/environment'
import { Transaction } from '../models/transaction';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class TransactionService {
  private _users = new BehaviorSubject<Transaction[]>([]);
  private dataStore: { users: Transaction[] } = { users: [] };
  readonly transactions = this._users.asObservable();
  url = 'https://localhost:5001/transactions';
  constructor(private http: HttpClient) { }
  getUserList() {

    let token = localStorage.getItem('jwt');
    if (token != null)
    {
      let decodedJWT = JSON.parse(window.atob(token.split('.')[1]));
    

      let email = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
      const header = new HttpHeaders().set('Authorization', 'Bearer' + localStorage.getItem('jwt'));
      let params = new HttpParams().set("userEmail", email);
      this.http.get<Transaction[]>(this.url, { headers: header, params: params }).subscribe(data => {
        this.dataStore.users = data;
        this._users.next(Object.assign({}, this.dataStore).users);
      },
        error => console.log('Could not load transactions.'));
    }
  }
}
