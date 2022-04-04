import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RolesService {

  constructor(private http:HttpClient) { }

  url = "http://localhost:9894/api/roles/"

  isCommunityManager(userid:number, comid:number) :Observable<boolean> {
    return this.http.get<boolean>(this.url+"isCommunityManager"+"?userid="+userid+"&comid="+comid);
  }
}


// http://localhost:9894/api/roles/isCommunityManager?userid=100&comid=100