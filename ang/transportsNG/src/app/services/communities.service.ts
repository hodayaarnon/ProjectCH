import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Community } from '../classes/community';

@Injectable({
  providedIn: 'root'
})
export class CommunitiesService {

  constructor(public http: HttpClient) { }

  url = "http://localhost:9894/api/communities/"

  allUserCommunities(userid:number):Observable<Array<Community>>
  {
    return this.http.get<Array<Community>>(this.url+"GetUserCommunities/"+userid);
  }
  
  getCommunityById(comid:number)
  {
    return this.http.get<Community>(this.url+"GetUserCommunities/"+comid);
  }
}

//  http://localhost:53684/api/communities/GetUserCommunities/100