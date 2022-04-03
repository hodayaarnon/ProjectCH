import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {

  loggedId=true;

  isAuth()
  {
    return this.loggedId;
  }
  constructor() { }
}
