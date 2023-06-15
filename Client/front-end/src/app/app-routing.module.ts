import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { ProducatoriListaComponent } from './producatori-lista/producatori-lista.component';
import { HttpClientModule } from '@angular/common/http';
import { ProducatorIndividualComponent } from './producator-individual/producator-individual.component';

const routes: Routes = [
  {path:'',component:WelcomePageComponent},
  {path:'producatori',
  component:ProducatoriListaComponent
  }
  ,{
    
    path:'producatori/:id',
    component:ProducatorIndividualComponent
  }
  ,{
    
    path:'create/producatori',
    component:ProducatorIndividualComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes),HttpClientModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
