import { Component, OnInit } from '@angular/core';
import { Joining } from 'src/app/classes/Joining';
import { User } from 'src/app/classes/user';
import { JoiningsService } from 'src/app/services/joinings.service';
import { UserService } from 'src/app/services/user.service';
import * as XLSX from 'xlsx';

@Component({
  selector: 'app-add-users',
  templateUrl: './add-users.component.html',
  styleUrls: ['./add-users.component.scss']
})
export class AddUsersComponent implements OnInit {

  constructor(public userServise: UserService, public joiningsService:JoiningsService) { }

  newUsers:Array<User>=new Array<User>()
  newJoining:Array<Joining>=new Array<Joining>()

  ngOnInit(): void {
  }

  DataFromEventEmitter(data: any) {
    this.newUsers=data;
    this.newJoining=new Array<Joining>()
    console.log(this.newUsers);
  }

  sendAndAdd()
  {
    this.userServise.addUsers(this.newUsers).subscribe(data=>{console.log('success!')}, e=>{console.log(5794000)})
  }
  addJoinings()
  {
    // this.newUsers.forEach(user => {
    //   this.newJoining.push(new Joining())
    // });
  }



}
