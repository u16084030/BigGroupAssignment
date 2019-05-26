import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { CauseService } from '../cause/cause.service';  
import { Cause } from '../cause/cause'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-cause',
  templateUrl: './cause.page.html',
  styleUrls: ['./cause.page.scss'],
})
export class CausePage implements OnInit {

  allCauses: object;

  constructor(private causeService:CauseService) { }

  ngOnInit() {

    this.loadAllCauses(); 
  }

  loadAllCauses() {  
    this.allCauses = this.causeService.getAllCauses();  
  } 

}
