import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';  
import { OutbreakService } from '../outbreak/outbreak.service';  
import { Outbreak } from '../outbreak/outbreak';

@Component({
  selector: 'app-outbreak',
  templateUrl: './outbreak.page.html',
  styleUrls: ['./outbreak.page.scss'],
})
export class OutbreakPage implements OnInit {

  allOutbreaks: object;

  constructor(private outbreakService:OutbreakService) { }

  ngOnInit() {

    this.loadAllOutbreaks();
  }
  loadAllOutbreaks() {  
    this.allOutbreaks = this.outbreakService.getAllOutbreaks();  
  } 
  

}
