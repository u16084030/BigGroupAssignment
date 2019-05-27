import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { PreventionService } from '../prevention/prevention.service';  
import { Prevention } from '../prevention/prevention'; 

@Component({
  selector: 'app-prevention',
  templateUrl: './prevention.page.html',
  styleUrls: ['./prevention.page.scss'],
})
export class PreventionPage implements OnInit {

  allPreventions: object;
  tmp: object;
  searchValue: string;

  constructor(private preventionService:PreventionService) { }

  ngOnInit() {
    this.loadAllPreventions(); 
  }

  loadAllPreventions() {  
    this.allPreventions = this.preventionService.getAllPreventions();  
  } 

  searchPreventions() {  
    let temp = this.searchValue;
    this.allPreventions = this.preventionService.searchPreventions(temp);  
    //console.log(tmp.AreaName);
    } 

}
