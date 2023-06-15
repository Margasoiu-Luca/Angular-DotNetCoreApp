import { Component, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MapperService } from '../services/Mapper';
import { switchMap } from 'rxjs';
import { Producator } from 'src/Models/Producator';
import { CrudInterface } from '../services/CrudInterface';
@Component({
  selector: 'app-producator-individual',
  templateUrl: './producator-individual.component.html',
  styleUrls: ['./producator-individual.component.css']
})
export class ProducatorIndividualComponent implements OnInit, OnDestroy, OnChanges {
  exists: boolean
  producator: Producator

  constructor(private mapper: MapperService, private route: ActivatedRoute, private myService: CrudInterface<Producator, number>, private router: Router) {
  }
  ngOnChanges(changes: SimpleChanges): void {
    throw new Error('Method not implemented.');
  }
  ngOnInit(): void {
    this.route.params.subscribe(r => {
      if (r["id"] == 'create') {
        this.exists = false
        this.producator = new Producator();
      }
      else {
        this.exists = true
        this.myService.get(r["id"]).subscribe(result => this.producator = result)
      }
    });
  }
  ngOnDestroy(): void {
  }

  public onSave(): void {
    this.myService.update(this.producator, this.producator.producatorId).subscribe((data) => alert(data.status), (error) => alert(error.message))
  }
  public onDelete(event: MouseEvent): void {
    this.myService.delete(this.producator.producatorId).subscribe((data) => {alert("Sters!"/*event.target*/);this.router.navigateByUrl('/producatori')}, (error) => alert(error.message))
  }
  GetStatusString(statusInt: number): string {
    switch (statusInt) {
      case 0:
        return "Activ";
        break;
      case 1:
        return "Inactiv";
        break;
      default:
        return "Sters";
        break;
    }
  }
  public onCreate():void{
    this.myService.create(this.producator).subscribe((data) => {alert("Creat!"/*event.target*/);this.router.navigateByUrl('/producatori')}, (error) => alert(error.message))
  }
}

