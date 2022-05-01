import { ask } from './../classes/ask';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AsksService {

  constructor(private http:HttpClient) { }

  url = "http://localhost:9894/api/askstojoin/";
  addAsk(ask:ask)
  {
    return this.http.put<ask>(this.url+"addAsk", ask);
  }
}
