import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { ActiveAreaService } from '../active-area/active-area.service';  
import { ActiveArea } from '../active-area/active-area'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-active-area',
  templateUrl: './active-area.component.html',
  styleUrls: ['./active-area.component.scss']
})
export class ActiveAreaComponent implements OnInit {

  allAreas: object;
  dataSaved = false;  
  activeAreaForm: any;  
  areaIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private activeAreaService:ActiveAreaService) { }

  ngOnInit() {  
         
    this.activeAreaForm = this.formbulider.group({  
    DiseaseID: ['', [Validators.required]],  
    AreaName: ['', [Validators.required]],  
     
  });
  this.loadAllAreas();

}

loadAllAreas() {  
  this.allAreas = this.activeAreaService.getAllActiveAreas();  
  } 

  onFormSubmit() {  
    this.dataSaved = false;  
    const area = this.activeAreaForm.value; 
    this.CreateArea(area);  
    this.activeAreaForm.reset();  
  }  
  loadAreaToEdit(areaId: number) {  
    this.activeAreaService.getAreaById(areaId).subscribe(area=> {  
      this.message = null;  
      this.dataSaved = false;  
      this.areaIdUpdate = 1;//cause.CauseID;  
      this.activeAreaForm.controls['DiseaseID'].setValue(1);//cause.DiseaseID);  
     this.activeAreaForm.controls['AreaName'].setValue("Fuck this");//cause.CauseDescription);   
    });  
  
  }  
  CreateArea(area: ActiveArea) {  
    if (this.areaIdUpdate == null) {  
      this.activeAreaService.addActiveArea(area).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.message = 'Record saved Successfully';  
          this.loadAllAreas();  
          this.areaIdUpdate = null;  
          this.activeAreaForm.reset();  
        }  
      );  
    } else {  
      area.AreaID = this.areaIdUpdate;  
      this.activeAreaService.updateActiveArea(area).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Updated Successfully';  
        this.loadAllAreas();  
        this.areaIdUpdate = null;  
        this.activeAreaForm.reset();  
      });  
    }  
  }   
  deleteArea(areaId: number) {  
    if (confirm("Are you sure you want to delete this ?")) {   
    this.activeAreaService.deleteActiveArea(areaId).subscribe(() => {  
      this.dataSaved = true;  
      this.message = 'Record Deleted Succefully';  
      this.loadAllAreas();  
      this.areaIdUpdate = null;  
      this.activeAreaForm.reset();  
  
    });  
  }  
}  
  resetForm() {  
    this.activeAreaForm.reset();  
    this.message = null;  
    this.dataSaved = false;  
  }
}
