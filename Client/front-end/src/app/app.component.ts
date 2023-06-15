import { Component, OnInit } from '@angular/core';
import { AppNavigationComponent } from './app-navigation/app-navigation.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { MapperService } from './services/Mapper';
import { createMap, createMapper } from '@automapper/core';
import { Producator } from 'src/Models/Producator';
import { ProducatorDTO } from 'src/Models/Producatordto';
import { classes } from '@automapper/classes';
import { ProdusDTO } from 'src/Models/Produs';
import 'automapper-ts';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  public title:"title"

  constructor(private http:HttpClient,private mapper:MapperService ){
    
  }
  ngOnInit(): void {
  }
}
