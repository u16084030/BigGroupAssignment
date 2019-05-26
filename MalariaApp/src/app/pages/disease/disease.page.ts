import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { DiseaseService } from '../disease/disease.service';  
import { Disease } from '../disease/disease';

@Component({
  selector: 'app-disease',
  templateUrl: './disease.page.html',
  styleUrls: ['./disease.page.scss'],
})
export class DiseasePage implements OnInit {

  allDiseases: object;

  constructor(private diseaseService:DiseaseService) { }

  ngOnInit() {

    this.loadAllDiseases();  
  }

  loadAllDiseases() {  
    this.allDiseases = this.diseaseService.getAllDiseases();  
  } 

}
