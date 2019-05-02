import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DiseaseComponent } from './disease/disease.component';
import { AppComponent } from './app.component';
import { CauseComponent } from './cause/cause.component';
import { OutbreakComponent } from './outbreak/outbreak.component';
import { PreventionComponent } from './prevention/prevention.component';
import { SpecialistComponent } from './specialist/specialist.component';
import { SubtypeComponent } from './subtype/subtype.component';
import { SuppliesListComponent } from './supplies-list/supplies-list.component';
import { SymptonComponent } from './sympton/sympton.component';
import { TreatmentComponent } from './treatment/treatment.component';
import { ActiveAreaComponent } from './active-area/active-area.component';
import { LoginComponent } from './login/login.component'; 

const routes: Routes = [
  { path: '', component: LoginComponent },//{ path: '', component: AppComponent }
  { path: 'app', component: AppComponent },
  { path: 'disease', component: DiseaseComponent },
  { path: 'cause', component: CauseComponent },
  { path: 'outbreak', component: OutbreakComponent },
  { path: 'prevention', component: PreventionComponent },
  { path: 'specialist', component: SpecialistComponent },
  { path: 'subtype', component: SubtypeComponent },
  { path: 'supplies-list', component: SuppliesListComponent },
  { path: 'sympton', component: SymptonComponent },
  { path: 'treatment', component: TreatmentComponent },
  { path: 'active-area', component: ActiveAreaComponent },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
