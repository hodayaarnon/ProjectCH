import { UserService } from './../../../services/user.service';
import { Component, OnInit } from '@angular/core';
import { SubscribeComponent } from '../subscribe/subscribe.component';
import { User } from 'src/app/classes/user';
import { Router } from '@angular/router';
import { CommunitiesService } from 'src/app/services/communities.service';
import { Community } from 'src/app/classes/community';
import { UserDetailsService } from 'src/app/services/user-details.service';
import { RolesService } from 'src/app/services/roles.service';

@Component({
  selector: '[app-connect]',
  templateUrl: './connect.component.html',
  styleUrls: ['./connect.component.scss']
})
export class ConnectComponent implements OnInit {

  constructor(public userService: UserService, public router: Router,
     public comService: CommunitiesService, public userdetails:UserDetailsService, public roleService:RolesService) { }

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
        this.userdetails.currentUser = data, console.log(data)
        if (data == null)
          alert("not found. try again....")
        else {
          this.setUser();
          this.findAllCommunities();
        }
      }, error => { console.log('fail: GetUserByEmailAndPassword') });
  }

  public setUser() {
    this.userdetails.currentCommunity = undefined
    this.userdetails.comArray = new Array<Community>()
    this.userdetails.isConect = true
    console.log(this.userdetails.currentUser);
  }

  public findAllCommunities() {
    if (this.userdetails.currentUser.Userid != undefined)
      this.comService.allUserCommunities(this.userdetails.currentUser.Userid)
        .subscribe(data => { this.userdetails.comArray = data }, e => { console.log('allUserCommunities failed!...') })
  }

  setCommunityAndRole(com: Community)
  {
    this.chooseCommunity(com)
    this.isManager()
    this.router.navigate(['/']);
  }
  chooseCommunity(com: Community) {
    if (com == null || com==undefined)
      return;
    this.userdetails.currentCommunity = com;
    console.log(this.userdetails.currentCommunity.communityName);
  }

  isManager() {
    
  }
}
