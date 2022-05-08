import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/classes/user';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-manage-community',
  templateUrl: './manage-community.component.html',
  styleUrls: ['./manage-community.component.scss']
})
export class ManageCommunityComponent implements OnInit {

  constructor(public userServise: UserService) { }

  

  ngOnInit(): void {
    
  }

 
}
