import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Joining } from '../classes/Joining';

@Injectable({
  providedIn: 'root'
})
export class JoiningsService {

  url = "http://localhost:9894/api/joinings/";

  constructor(private myhttp: HttpClient) { }

  addJoining(joining:Joining)
  {
    return this.myhttp.put<Joining>(this.url+"addJoining", joining);
  }
}
