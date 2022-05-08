import { HttpClient } from '@angular/common/http';
import { Injectable, NgModule } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from './../classes/user';
@Injectable({
  providedIn: 'root',
})
export class UserService {

  url = "http://localhost:9894/api/users/";
  subscribeUser:User= new User()

  constructor(private myhttp: HttpClient) { }

  GetUserByEmailAndPassword(email: string, password: string): Observable<User> 
  {
    return this.myhttp.get<User>(this.url + "GetUserByEmailAndPassword" + "?email=" + email + "&password=" + password);
  }

  addUser(user:User)
  {
    return this.myhttp.put<User>(this.url + "addUser", user);
  }

  addUsers(users:Array<User>)
  {
    return this.myhttp.put<User>(this.url + "addUsers", users);
  }
  GetUserRolesInCommunity(userid:number, comid:number)
  {
    
  }


  
}
//http://localhost:53684/api/users/GetUserByEmailAndPassword?email=danier@gmail.com&password=Dan8787