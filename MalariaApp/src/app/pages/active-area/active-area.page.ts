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
  tmp: object;
  searchValue: string;
  closeSearch: boolean;

  constructor(private activeAreaService:ActiveAreaService) { }

  ngOnInit() {
    this.closeSearch = true;
    this.loadAllAreas();
  }

  loadAllAreas() {  
    this.allAreas = this.activeAreaService.getAllActiveAreas();  
    } 

  searchAreas() {  
      let temp = this.searchValue;
      this.closeSearch = false;
      //console.log(temp);
      //this.tmp = {temp};
      this.allAreas = this.activeAreaService.searchActiveAreas(temp);  
      //console.log(tmp.AreaName);
      } 

}
