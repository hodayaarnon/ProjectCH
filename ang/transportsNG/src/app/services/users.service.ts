import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from './../classes/user';
@Injectable({
  providedIn: 'root',
})
export class UsersService {
  constructor(private myhttp: HttpClient) {}

result:any;

  getCount() {
    this.myhttp.get('/api/users').subscribe((res) => {
      console.log(res);
      this.result=res;
    });
    return this.result;
  }

}


