import { Component, OnInit,Input } from '@angular/core';
import { CrudInterface } from '../services/CrudInterface';
import { Producator } from 'src/Models/Producator';
import { DataService } from '../services/SomeTextDataService';
import { MapperService } from '../services/Mapper';
import { ProducatorDTO } from 'src/Models/Producatordto';
import { AutoMap, classes } from '@automapper/classes';
import { keys } from 'ts-transformer-keys';
@Component({
  selector: 'app-producatori-lista',
  templateUrl: './producatori-lista.component.html',
  styleUrls: ['./producatori-lista.component.css']
})
export class ProducatoriListaComponent implements OnInit{


  hero:string | undefined
  data:ProducatorDTO[]=[]

  constructor(private myService: CrudInterface<Producator,number>,private dataservice:DataService, private mapperService:MapperService) {
  }
  ngOnInit(): void {
    this.myService.getAll().subscribe(returnedValue=>returnedValue.map(producator => {
      this.data.push(this.mapperService.mapProducatorToProducatorDTO(producator))
      // console.log(this.mapperService.mapper.map('ProducatorToDTO',ProducatorDTO,producator))
    }
      ));
    this.hero=this.dataservice.hero
    console.log(keys<Producator>)
  }

}


// UserDto { firstName: 'Auto', lastName: 'Mapper', fullName: 'Auto Mapper' }