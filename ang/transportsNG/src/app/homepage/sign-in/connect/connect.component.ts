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

  constructor(public userService:UserService, public router: Router, public comService:CommunitiesService) { }

  ngOnInit(): void {
  }

  
  userPassword=""
  userEmail=""



  login()
  {
    this.GetUserByEmailAndPassword();
  }

  GetUserByEmailAndPassword()
  {
    this.userService.GetUserByEmailAndPassword(this.userEmail, this.userPassword)
    .subscribe(data=>{
      this.userService.currentUser=data, console.log('data set '+this.userService.currentUser.UserId + data.UserId)
      if(data==null)
      alert("not found. try again....")
      //this.router.navigate(['/NavComponent/SignUpComponent'])
      else
      {//this.setUser();
        console.log('entered setUser')
     // this.selectCommunity()
    }
    
    }, error=>{console.log('fail: GetUserByEmailAndPassword')});
    
    //this.setUser()
    
  }
 public setUser()
  {
    console.log('entered setUser f')
    this.comService.currentCommunity=null
    this.comService.comArray=new Array<Community>()
    this.userService.isConect=true
    console.log(this.userService.currentUser);
    //this.router.navigate(['/']);
    console.log('entered select')
    this.selectCommunity();
    
  }

 public selectCommunity()
  {
      //בסרויס קהילות צריך להגדיר משתנה קהילה ננוכחית
      console.log('entered select f') 
      console.log(this.userService.currentUser.UserId+" this.userService.currentUse")
      if(this.userService.currentUser.UserId != undefined)
        this.comService.allUserCommunities(this.userService.currentUser.UserId)
        .subscribe(data=>{this.f(data)}, e=>{console.log('allUserCommunities failed!...')})
        
  }
  f(data:any)
  { 
    debugger;
    console.log(this.comService.currentCommunity==null && this.userService.currentUser!=undefined+"kkkk");
    console.log(this.comService.comArray+"kkhhg")
    console.log(data)
    this.comService.comArray=data
   
  }
}
