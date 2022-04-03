import { UserService } from './../../../services/user.service';
import { Component, OnInit } from '@angular/core';
import { SubscribeComponent } from '../subscribe/subscribe.component';
import { User } from 'src/app/classes/user';
import { Router } from '@angular/router';
import { CommunitiesService } from 'src/app/services/communities.service';
import { Community } from 'src/app/classes/community';

@Component({
  selector: '[app-connect]',
  templateUrl: './connect.component.html',
  styleUrls: ['./connect.component.scss']
})
export class ConnectComponent implements OnInit {

  constructor(public userService: UserService, public router: Router, public comService: CommunitiesService) { }

  ngOnInit(): void {

  }


  userPassword = ""
  userEmail = ""



  login() {
    this.GetUserByEmailAndPassword();
  }

  GetUserByEmailAndPassword() {
    this.userService.GetUserByEmailAndPassword(this.userEmail, this.userPassword)
      .subscribe(data => {
        this.userService.currentUser = data, console.log(data)
        if (data == null)
          alert("not found. try again....")
        //this.router.navigate(['/NavComponent/SignUpComponent'])
        else {
          this.setUser();
          this.findAllCommunities();
        }
      }, error => { console.log('fail: GetUserByEmailAndPassword') });
  }
  public setUser() {
    this.comService.currentCommunity = undefined
    this.comService.comArray = new Array<Community>()
    this.userService.isConect = true
    console.log(this.userService.currentUser);
    //this.router.navigate(['/']);
  }

  public findAllCommunities() {
    //בסרויס קהילות צריך להגדיר משתנה קהילה ננוכחית

    if (this.userService.currentUser.Userid != undefined)
      this.comService.allUserCommunities(this.userService.currentUser.Userid)
        .subscribe(data => { this.comService.comArray = data }, e => { console.log('allUserCommunities failed!...') })

  }

  chooseCommunity(com: Community) {
    if (com == null)
      return;
    this.comService.currentCommunity = com;
    console.log(this.comService.currentCommunity.communityName)
  }
}
