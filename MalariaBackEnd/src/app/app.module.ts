import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DiseaseComponent } from './disease/disease.component';
import { ActiveAreaComponent } from './active-area/active-area.component';
import { CauseComponent } from './cause/cause.component';
import { OutbreakComponent } from './outbreak/outbreak.component';
import { PreventionComponent } from './prevention/prevention.component';
import { SpecialistComponent } from './specialist/specialist.component';
import { SubtypeComponent } from './subtype/subtype.component';
import { SuppliesListComponent } from './supplies-list/supplies-list.component';
import { SymptonComponent } from './sympton/sympton.component';
import { TreatmentComponent } from './treatment/treatment.component';
import { NavComponent } from './nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    DiseaseComponent,
    ActiveAreaComponent,
    CauseComponent,
    OutbreakComponent,
    PreventionComponent,
    SpecialistComponent,
    SubtypeComponent,
    SuppliesListComponent,
    SymptonComponent,
    TreatmentComponent,
    NavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
