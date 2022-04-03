import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TransportsService {

  trans:any;

  constructor(private myhttp: HttpClient) { }


  getTrans() {
    this.myhttp.get('/api/Transports').subscribe((res) => {
      console.log(res);
      this.trans=res;
    });
    return this.trans;
  }
}
