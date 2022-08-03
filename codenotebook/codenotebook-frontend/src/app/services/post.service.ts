import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  private url = 'https://localhost:5001/api/Test';

  constructor(private httpClient: HttpClient) { }

  getPosts() {
    return this.httpClient.get(this.url);
  }

}
