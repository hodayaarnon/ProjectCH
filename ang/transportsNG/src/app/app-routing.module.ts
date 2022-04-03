import { EmptyComponent } from './empty/empty.component';
import { AddDeliveryComponent } from './homepage/view-delivery/add-delivery/add-delivery.component';

import { SubscribeComponent } from './homepage/sign-in/subscribe/subscribe.component';
import { ConnectComponent } from './homepage/sign-in/connect/connect.component';
import { ManageDeliveryComponent } from './homepage/manage-delivery/manage-delivery.component';
import { ViewSuggestionsComponent } from './homepage/manage-delivery/view-suggestions/view-suggestions.component';
import { ViewDeliveryDetailsComponent } from './homepage/manage-delivery/view-delivery-details/view-delivery-details.component';
import { HomecontentComponent } from './homepage/homecontent/homecontent.component';
import { HomepageComponent } from './homepage/homepage.component';
import { ViewHistoryComponent } from './homepage/view-history/view-history.component';
import { ViewDetailsComponent } from './homepage/view-delivery/view-details/view-details.component';
import { ViewDeliveryComponent } from './homepage/view-delivery/view-delivery.component';
import { SignInComponent } from './homepage/sign-in/sign-in.component';
import { ManageCommunityComponent } from './homepage/manage-community/manage-community.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes, CanActivate } from '@angular/router';
import { JoinCommunityComponent } from './homepage/join-community/join-community.component';
import { MessagesComponent } from './homepage/manage-delivery/messages/messages.component';
import { Subscription } from 'rxjs';
import { ViewdeliverycontentComponent } from './homepage/view-delivery/viewdeliverycontent/viewdeliverycontent.component';
import { AuthGuard } from './auth.guard';

const routes: Routes = [
{path:'', component:HomecontentComponent },
{path:'homecontent',  component: HomecontentComponent},
{path:'joincommunity', component:JoinCommunityComponent},
{path:'managedelivery', component:ManageDeliveryComponent, 
    children:[
      {path:'', component:ViewDeliveryDetailsComponent},
      {path:'messages',component:MessagesComponent },
      {path:'deliverydetails',component:ViewDeliveryDetailsComponent },
      {path:'suggestions',component:ViewSuggestionsComponent },
  ]},
{path:'signin', component:SignInComponent, 
  children:[{path:'', component:ConnectComponent,},
            {path:'connect', component:ConnectComponent},
            {path:'subscribe', component:SubscribeComponent, children:[{path:'show',component:ViewHistoryComponent}]} ]

},
{path:'viewdelivery', component:ViewDeliveryComponent,
      children:[
              {path:'', component:ViewdeliverycontentComponent, 
              children:[{path:'viewdetailsofdelivery', component:ViewDetailsComponent},
              {path:'dontshow', component:EmptyComponent},
            ]},
              {path:'adddelivery', component:AddDeliveryComponent},
              ]
             

},
{path:'viewhistory', component:ViewHistoryComponent, canActivate:[AuthGuard]},
{path:'managecommunity', component:ManageCommunityComponent},

//{path:'backtohome', component:HomecontentComponent},

//{path:'**', component:HomecontentComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
