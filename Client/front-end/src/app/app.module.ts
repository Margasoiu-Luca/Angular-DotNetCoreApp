import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppNavigationComponent } from './app-navigation/app-navigation.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { ProducatoriListaComponent } from './producatori-lista/producatori-lista.component';
import { CrudInterface } from './services/CrudInterface';
import { Producator } from 'src/Models/Producator';
import { ProducatorCrud } from './services/ProducatorCrud';
import { DataService } from './services/SomeTextDataService';
import { MapperService } from './services/Mapper';
import { ProducatorIndividualComponent } from './producator-individual/producator-individual.component';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    AppNavigationComponent,
    WelcomePageComponent,
    ProducatoriListaComponent,
    ProducatorIndividualComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule
  ],
  providers: [
    {
      provide:CrudInterface<Producator,number>,
      useClass:ProducatorCrud
    },
    DataService,
    MapperService,
    RouterModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
