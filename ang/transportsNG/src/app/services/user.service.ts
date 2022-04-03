import { HttpClient } from '@angular/common/http';
import { Injectable, NgModule } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from './../classes/user';
@Injectable({
  providedIn: 'root',
})
export class UserService {

  constructor(private myhttp: HttpClient) { }

  lUser: Array<User> = new Array<User>()
  url = "http://localhost:9894/api/users/"

  currentUser: User = new User()
  isConect:boolean=false


  userMailSignUp?: string = ""
  newUser?: User = undefined
  
  show: boolean = false
  firstname!: string
  lastname!: string
  identity!: string
  postalcode!: string
  email!: string
  password!: string
  address!: string
  housenumber!: number
  city!: string
  country!: string

  selectedCommunity=null
  //פרטים נוספים שצריך לשמור על המשתמש

  communityid!: number
  maypublish!: boolean
  roleid!: number

  GetUserByEmailAndPassword(email: string, password: string): Observable<User> {
    return this.myhttp.get<User>(this.url + "GetUserByEmailAndPassword" + "?email=" + email + "&password=" + password);
  }
// http://localhost:53684/api/users/GetUserByEmailAndPassword?email=danier@gmail.com&password=Dan8787

}