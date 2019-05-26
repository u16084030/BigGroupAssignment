import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { SubtypeService } from '../subtype/subtype.service';  
import { Subtype } from '../subtype/subtype'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-subtype',
  templateUrl: './subtype.page.html',
  styleUrls: ['./subtype.page.scss'],
})
export class SubtypePage implements OnInit {

  allSubtypes: object;

  constructor(private subtypeService:SubtypeService) { }

  ngOnInit() {
    this.loadAllSubtypes();
  }

  loadAllSubtypes() {  
    this.allSubtypes = this.subtypeService.getAllSubtypes();  
  } 

}
