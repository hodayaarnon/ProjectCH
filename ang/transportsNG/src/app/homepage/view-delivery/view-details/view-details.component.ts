import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view-details',
  templateUrl: './view-details.component.html',
  styleUrls: ['./view-details.component.scss']
})
export class ViewDetailsComponent implements OnInit {

  constructor() { }
  public hide:boolean=false;
  ngOnInit(): void {
  }

  hidef()
  {
    this.hide=true;
  }
}
