import { TransportsService } from './../services/transports.service';
import { Component, OnInit } from '@angular/core';
import { UsersService } from '../services/users.service';


@Component({
  selector: 'app-show-results',
  templateUrl: './show-results.component.html',
  styleUrls: ['./show-results.component.scss']
})
export class ShowResultsComponent implements OnInit {

  result:any;
  trans:any;
  constructor(private userservice:UsersService, private tr: TransportsService) { }

  ngOnInit(): void {
  }

  public clickToResult()
  {
    this.result=this.userservice.getCount();
  }

  public clickToGetTrans()
  {
    this.trans=this.tr.getTrans();
  }
}
