import { UserDetailsService } from 'src/app/services/user-details.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-homecontent',
  templateUrl: './homecontent.component.html',
  styleUrls: ['./homecontent.component.scss']
})
export class HomecontentComponent implements OnInit {

  constructor(public userDetailsService:UserDetailsService) { }

  ngOnInit(): void {
  }

}
