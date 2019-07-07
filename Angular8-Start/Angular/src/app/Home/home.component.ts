import { Component, OnInit } from '@angular/core';
import { HomeService } from '../Service/Home.Service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass'],
  providers: [HomeService]
})
export class HomeComponent implements OnInit {
  
  st:any;
  constructor(private _homeService: HomeService) { }

  ngOnInit() {
     this.st =  this._homeService.GetService();
  }



}
