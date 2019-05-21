import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { ActiveAreaService } from '../active-area/active-area.service';  
import { ActiveArea } from '../active-area/active-area'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-active-area',
  templateUrl: './active-area.page.html',
  styleUrls: ['./active-area.page.scss'],
})
export class ActiveAreaPage implements OnInit {

  allAreas: object;

  constructor(private activeAreaService:ActiveAreaService) { }

  ngOnInit() {

    this.loadAllAreas();
  }

  loadAllAreas() {  
    this.allAreas = this.activeAreaService.getAllActiveAreas();  
    } 

}
