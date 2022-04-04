import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Community } from '../classes/community';
import { User } from '../classes/user';

@Injectable({
  providedIn: 'root'
})
export class UserDetailsService {

  constructor(private myhttp: HttpClient) { }

  lUser: Array<User> = new Array<User>()
  currentUser: User = new User()
  isConect:boolean=false
  isManager:boolean=false
  isAuthToPublish:boolean=false
  selectedCommunity=null
  currentCommunity?:Community=undefined
  comArray:Array<Community>=new Array<Community>()

}
