import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { SymptomsService } from '../symptoms/symptoms.service';  
import { Symptoms } from '../symptoms/symptoms'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-symptoms',
  templateUrl: './symptoms.page.html',
  styleUrls: ['./symptoms.page.scss'],
})
export class SymptomsPage implements OnInit {

  allSymptons: object;
  tmp: object;
  searchValue: string;

  constructor(private symptomsService:SymptomsService) { }

  ngOnInit() {
    this.loadAllSymptons();
  }

  loadAllSymptons() {  
    this.allSymptons = this.symptomsService.getAllSymptoms();  
  } 

  searchSymptoms() {  
    let temp = this.searchValue;
    this.allSymptons = this.symptomsService.searchSymptoms(temp);  
    //console.log(tmp.AreaName);
    }

}
