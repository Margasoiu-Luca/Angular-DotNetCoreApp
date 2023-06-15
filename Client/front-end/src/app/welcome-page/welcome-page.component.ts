import { Component, OnDestroy, OnInit } from '@angular/core';
import { DataService } from '../services/SomeTextDataService';

@Component({
  selector: 'app-welcome-page',
  templateUrl: './welcome-page.component.html',
  styleUrls: ['./welcome-page.component.css']
})
export class WelcomePageComponent implements OnDestroy, OnInit{
  hero:string | undefined
  ngOnDestroy(): void {
    this.dataservice.hero=this.hero
  }
  ngOnInit(): void {
    this.hero="abcd"
  }
  /**
   *
   */
  constructor(private dataservice:DataService) {
  }

}
