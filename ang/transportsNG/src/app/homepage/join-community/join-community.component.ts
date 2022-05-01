import { UserDetailsService } from './../../services/user-details.service';
import { AsksService } from './../../services/asks.service';
import { ask } from './../../classes/ask';
import { CommunitiesService } from 'src/app/services/communities.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Community } from 'src/app/classes/community';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-join-community',
  templateUrl: './join-community.component.html',
  styleUrls: ['./join-community.component.scss']
})
export class JoinCommunityComponent implements OnInit {

  allCommunities:Array<Community>=new Array<Community>()
  addAskForm:FormGroup= new FormGroup({
    // Validators.required- require to enter a value to this input
     "communityid"!:new FormControl(null, [Validators.required]),
     "communityname"!:new FormControl(null, [Validators.required]),
     "asmanager"!:new FormControl(false, [])})

  constructor(public router:Router, public communitiesService:CommunitiesService, public asksService:AsksService, public userDetailsService:UserDetailsService) { }

  ngOnInit(): void {
    this.communitiesService.getAllCommunities().subscribe(data=>{this.allCommunities=data}, e=>{console.log('problem with allCommunities')})
  }

  checkRoute(route:string)
  {
    if(this.router.url===route)
    return true; return false;
  }
  getAllCommunities()
  {
    this.communitiesService.getAllCommunities().subscribe(data=>{this.allCommunities=data}, e=>{console.log('problem with allCommunities')})
  }

  addAsk()
  {
    var a=new ask()
    a.Askid=0
    a.Communityid=this.addAskForm.get('communityid')?.value
    a.Communityname=this.addAskForm.get('communityname')?.value
    a.Joinasamanager=this.addAskForm.get('asmanager')?.value
    a.Userid=this.userDetailsService.currentUser.Userid

    console.log(this.addAskForm.get('asmanager')?.value)
    console.log(this)
   this.asksService.addAsk(<ask>a).subscribe(data=>{console.log('added ask')}, e=>{console.log('ask was not added')})
  }
}
