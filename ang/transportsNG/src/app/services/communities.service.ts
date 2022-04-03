import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Community } from '../classes/community';

@Injectable({
  providedIn: 'root'
})
export class CommunitiesService {

  constructor(public http: HttpClient) { }

  currentCommunity=null
  comArray:Array<Community>=new Array<Community>()
  url = "http://localhost:53684/api/communities/"

//  http://localhost:53684/api/communities/GetUserCommunities/100
  allUserCommunities(id:number):Observable<Array<Community>>
  {
    return this.http.get<Array<Community>>(this.url+"GetUserCommunities/"+id);
  }
}
