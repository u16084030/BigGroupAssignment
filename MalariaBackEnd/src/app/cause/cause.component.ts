import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { CauseService } from '../cause/cause.service';  
import { Cause } from '../cause/cause'; 

@Component({
  selector: 'app-cause',
  templateUrl: './cause.component.html',
  styleUrls: ['./cause.component.scss']
})
export class CauseComponent implements OnInit {

  allCauses: Object;

  constructor(private formbulider: FormBuilder, private causeService:CauseService) { }

  ngOnInit() {    
      this.loadAllCauses();  
    }  

    loadAllCauses() {  
      this.allCauses = this.causeService.getAllCauses();  
      //this.causeService.getAllCauses().subscribe(data => {
        //this.allCauses = data
        //console.log(this.allCauses)
    }

  }

