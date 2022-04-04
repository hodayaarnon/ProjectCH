import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../services/user.service';
import { Router } from '@angular/router';
import { FormsModule } from "@angular/forms";

@Component({
  selector: '[app-subscribe]',
  templateUrl: './subscribe.component.html',
  styleUrls: ['./subscribe.component.scss']
})
export class SubscribeComponent implements OnInit {

  userMail: string = ""
  password: string = ""

  constructor(public userServise: UserService, public router: Router) { }

  ngOnInit(): void {
  }

  check()
  {
    debugger
    console.log(this.userMail)
    console.log(this.password)

    //בדיקה האם מנהל
    // if (this.userServise.userMail == this.userServise.managerName.trim() && this.userServise.password == this.userServise.managerPassword.trim()) {
    //   debugger
    //   this.userServise.show = true
    //   this.userServise.isConect = true
    //   this.userServise.profileName = this.userMail
    //   this.router.navigate(['/NavComponent/ManagerComponent'])
    // }
    // //בדיקה האם הלקוח כבר קיים
    // else {
    //   debugger
    //   this.userServise.GetUserByMailAndPassword(this.userServise.userMail, this.userServise.password).subscribe(data => {
    //     debugger;
    //     this.userServise.currentUser = data;
    //     if(data==null)
    //     alert('please sign up...')
    //     this.router.navigate(['/NavComponent/SignUpComponent'])
    //     console.log(this.userServise.currentUser);
    //     if (this.userServise.currentUser.UserName != null)
    //       this.userServise.isConect = true;
    //     else
    //     this.userServise.isConect = false;
    //     this.userServise.userMail = this.userMail;
    //     this.alerting();
    //     this.checkUser()
    //   }, err => { alert("שגיאת רשת") })
    // }
  }

  addUser()
  {
    console.log(this)
  }

}
