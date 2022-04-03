import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-join-community',
  templateUrl: './join-community.component.html',
  styleUrls: ['./join-community.component.scss']
})
export class JoinCommunityComponent implements OnInit {

  constructor(public router:Router) { }

  ngOnInit(): void {
  }

  checkRoute(route:string)
  {
    if(this.router.url===route)
    return true; return false;
  }
}
