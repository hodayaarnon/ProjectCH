import { Component, OnInit } from '@angular/core';
import { Transport } from 'src/app/classes/transport';

@Component({
  selector: 'app-panel',
  templateUrl: './panel.component.html',
  styleUrls: ['./panel.component.scss']
})
export class PanelComponent implements OnInit {

  constructor() { }

  transportsArr:any[]=[
    {
      source:'jerusalem', destination:'bnei-brak', weight:32.8, deadline:new Date("2016-01-05"),  from:new Date("2018-01-05"), description:'a present'
    }, 
    {
      source:'jerusalem', destination:'tiberias', weight:2.8, deadline:new Date("2016-01-05"),  from:new Date("2018-01-15"), description:'a birthday suprise'
    },
    {
      source:'haifa', destination:'bnei-brak', weight:89, deadline:new Date("2019-10-31"),  from:new Date("2012-01-23"), description:'medical eqquipment'
    }
  ]
  statusIcons:string[]=[

  ]
  ngOnInit(): void {
  }

}
