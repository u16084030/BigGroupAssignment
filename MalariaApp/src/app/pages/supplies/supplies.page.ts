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
  tmp: object;
  searchValue: string;

  constructor(private suppliesService:SuppliesService) { }

  ngOnInit() {
    this.loadAllSupplies();
  }
  loadAllSupplies() {  
    this.allSupplies = this.suppliesService.getAllSuppliesLists();  
  } 

  searchSupplies() {  
    let temp = this.searchValue;
    this.allSupplies = this.suppliesService.searchSupplies(temp);  
    //console.log(tmp.AreaName);
    } 

}
