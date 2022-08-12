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
    const header = new HttpHeaders().set('Authorization', 'Bearer' + localStorage.getItem('jwt'));
    //let params = new HttpParams().set("userId", 4);
    this.http.get<Transaction[]>(this.url + '/4', { headers: header }).subscribe(data => {
      this.dataStore.users = data;
      this._users.next(Object.assign({}, this.dataStore).users);
    },
      error => console.log('Could not load transactions.'));
  }

}
