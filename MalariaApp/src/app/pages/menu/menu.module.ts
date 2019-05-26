import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { IonicModule } from '@ionic/angular';

import { MenuPage } from './menu.page';

const routes: Routes = [
  {
    path: 'menu',
    component: MenuPage,
    children: [
      
      { path: 'disease', 
        loadChildren: '../disease/disease.module#DiseasePageModule'
      },
      { path: 'active-area', 
        loadChildren: '../active-area/active-area.module#ActiveAreaPageModule' 
      },
      { path: 'cause', 
        loadChildren: '../cause/cause.module#CausePageModule' 
      },
      { path: 'outbreak', 
        loadChildren: '../outbreak/outbreak.module#OutbreakPageModule' 
      },
      { path: 'prevention', 
        loadChildren: '../prevention/prevention.module#PreventionPageModule' 
      },
      { path: 'subtype', 
        loadChildren: '../subtype/subtype.module#SubtypePageModule' 
      },
      { path: 'supplies', 
        loadChildren: '../supplies/supplies.module#SuppliesPageModule' 
      },
      { path: 'symptoms', 
        loadChildren: '../symptoms/symptoms.module#SymptomsPageModule' 
      },
      { path: 'treatment', 
        loadChildren: '../treatment/treatment.module#TreatmentPageModule' 
      }
    ]
  },
  {
    path: '',
    redirectTo: '/menu/disease'
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [MenuPage]
})
export class MenuPageModule {}
