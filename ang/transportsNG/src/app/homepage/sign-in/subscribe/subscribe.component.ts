import { User } from './../../../classes/user';
import { Component, OnInit } from '@angular/core';
import { UserService } from '../../../services/user.service';
import { Router } from '@angular/router';
import { FormControl, FormGroup, FormsModule, Validators } from "@angular/forms";
import { CommunitiesService } from 'src/app/services/communities.service';
import { Community } from 'src/app/classes/community';

@Component({
  selector: '[app-subscribe]',
  templateUrl: './subscribe.component.html',
  styleUrls: ['./subscribe.component.scss']
})
export class SubscribeComponent implements OnInit {

  userMail: string = ""
  password: string = ""

  
  subscribeUser:User=new User()

  constructor(public userServise: UserService, public router: Router, public communitiesService:CommunitiesService) { }

  ngOnInit(): void {
   // this.communitiesService.getAllCommunities().subscribe(data=>{this.allCommunities=data}, e=>{console.log('problem with allCommunities')})
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
    this.subscribeUser.Userfirstname=this.myFormGroup.get('firstname')?.value;
    this.subscribeUser.Userlastname=this.myFormGroup.get('lastname')?.value;
    this.subscribeUser.City=this.myFormGroup.get('city')?.value;
    this.subscribeUser.Email=this.myFormGroup.get('email')?.value;
    this.subscribeUser.Street=this.myFormGroup.get('street')?.value;
    this.subscribeUser.Housenumber=this.myFormGroup.get('housenumber')?.value;
    this.subscribeUser.Adresslat=this.myFormGroup.get('latitude')?.value;
    this.subscribeUser.Adresslng=this.myFormGroup.get('longitude')?.value;
    this.subscribeUser.Postalcode=this.myFormGroup.get('postalcode')?.value;
    this.subscribeUser.Userpassword=this.myFormGroup.get('password')?.value;
    this.subscribeUser.Userid=0;
  
    console.log(this)
    this.userServise.addUser(this.subscribeUser).subscribe(data=>{console.log('success!')}, e=>{console.log(5794000)})
  }


  myFormGroup:FormGroup= new FormGroup({
    // Validators.required- require to enter a value to this input
     //"firstname"!:new FormControl(null, [Validators.required]),
     "firstname"!:new FormControl(null, [Validators.pattern('^[א-תa-zA-Z ]+$'), Validators.required]),
     "lastname"!:new FormControl(null, [Validators.pattern('^[א-תa-zA-Z ]+$'), Validators.required]),
     "email"!:new FormControl(null, [Validators.required]),
     "password"!:new FormControl(null, [Validators.required, Validators.minLength(6), Validators.maxLength(50)]),
     "city"!:new FormControl(null, [Validators.required]),
     //"city"!:new FormControl(null, [Validators.required]),
     "street"!:new FormControl(null, [Validators.required]),
     "housenumber"!:new FormControl(null, [Validators.required]),
     "postalcode"!:new FormControl(null, [Validators.required]),
     "latitude"!:new FormControl(null, [Validators.required]),
     "longitude"!:new FormControl(null, [Validators.required]),
     
   })

  
}
