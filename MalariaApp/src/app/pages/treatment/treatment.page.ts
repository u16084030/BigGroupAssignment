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
  tmp: object;
  searchValue: string;

  constructor(private treatmentService:TreatmentService) { }

  ngOnInit() {
    this.loadAllTreatments();
  }

  loadAllTreatments() {  
    this.allTreatments = this.treatmentService.getAllTreatments();  
  } 

  searchTreatments() {  
    let temp = this.searchValue;
    this.allTreatments = this.treatmentService.searchTreatments(temp);  
    //console.log(tmp.AreaName);
    }

}
