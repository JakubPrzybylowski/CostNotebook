import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import {environment } from '../environments/environment'
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class BillService {
  private _users = new BehaviorSubject<User[]>([]);
  private dataStore: { users: User[] } = { users: [] };
  readonly users = this._users.asObservable();
  url = 'https://localhost:5001/api';
  constructor(private http: HttpClient) { }
  getUserList() {
    this.http.get<User[]>(this.url).subscribe(data => {
      this.dataStore.users = data;
      this._users.next(Object.assign({}, this.dataStore).users);
    },
      error => console.log('Could not load users.'));
  }

}
