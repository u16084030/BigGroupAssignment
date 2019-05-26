import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { SuppliesService } from '../supplies/supplies.service';  
import { Supplies } from '../supplies/supplies'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-supplies',
  templateUrl: './supplies.page.html',
  styleUrls: ['./supplies.page.scss'],
})
export class SuppliesPage implements OnInit {

  allSupplies: object;

  constructor(private suppliesService:SuppliesService) { }

  ngOnInit() {
    this.loadAllSupplies();
  }
  loadAllSupplies() {  
    this.allSupplies = this.suppliesService.getAllSuppliesLists();  
  } 

}
