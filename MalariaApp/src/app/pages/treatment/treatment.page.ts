import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { TreatmentService } from '../treatment/treatment.service';  
import { Treatment } from '../treatment/treatment'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-treatment',
  templateUrl: './treatment.page.html',
  styleUrls: ['./treatment.page.scss'],
})
export class TreatmentPage implements OnInit {

  allTreatments: object;

  constructor(private treatmentService:TreatmentService) { }

  ngOnInit() {
    this.loadAllTreatments();
  }

  loadAllTreatments() {  
    this.allTreatments = this.treatmentService.getAllTreatments();  
  } 

}
