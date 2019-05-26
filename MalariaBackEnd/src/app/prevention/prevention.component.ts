import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { PreventionService } from '../prevention/prevention.service';  
import { Prevention } from '../prevention/prevention'; 

@Component({
  selector: 'app-prevention',
  templateUrl: './prevention.component.html',
  styleUrls: ['./prevention.component.scss']
})
export class PreventionComponent implements OnInit {

  allPreventions: object;
  dataSaved = false;  
  preventionForm: any;  
  preventionIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private preventionService:PreventionService) { }

  ngOnInit() {    
      this.preventionForm = this.formbulider.group({  
      CauseID: ['', [Validators.required]],  
      PreventDescription: ['', [Validators.required]],  
      PreventEffective: ['', [Validators.required]], 
    });
      this.loadAllPreventions();  
    }  
    loadAllPreventions() {  
      this.allPreventions = this.preventionService.getAllPreventions();  
    } 
    
    onFormSubmit() {  
      this.dataSaved = false;  
      const prevention = this.preventionForm.value;  
      this.CreatePrevention(prevention);  
      this.preventionForm.reset();  
    }  
    loadPreventionToEdit(prevention: Prevention) {  
      this.preventionService.updatePrevention(prevention).subscribe(()=> {  
        this.message = null;  
        this.dataSaved = false;  
        this.preventionIdUpdate = prevention.PreventID;  
        this.preventionForm.controls['CauseID'].setValue(prevention.CauseID);  
       this.preventionForm.controls['PreventDescription'].setValue(prevention.PreventDescription);  
        this.preventionForm.controls['PreventEffective'].setValue(prevention.PreventEffective);  
      });  
    
    }  
    CreatePrevention(prevention: Prevention) {  
      if (this.preventionIdUpdate == null) {  
        this.preventionService.addPrevention(prevention).subscribe(  
          () => {  
            this.dataSaved = true;  
            this.message = 'Record saved Successfully';  
            this.loadAllPreventions();  
            this.preventionIdUpdate = null;  
            this.preventionForm.reset();  
          }  
        );  
      } else {  
        prevention.PreventID = this.preventionIdUpdate;  
        this.preventionService.updatePrevention(prevention).subscribe(() => {  
          this.dataSaved = true;  
          this.message = 'Record Updated Successfully';  
          this.loadAllPreventions();  
          this.preventionIdUpdate = null;  
          this.preventionForm.reset();  
        });  
      }  
    }   
    deletePrevention(preventionId: number) {  
      if (confirm("Are you sure you want to delete this ?")) {   
      this.preventionService.deletePrevention(preventionId).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Deleted Succefully';  
        this.loadAllPreventions();  
        this.preventionIdUpdate = null;  
        this.preventionForm.reset();  
    
      });  
    }  
  }  
    resetForm() {  
      this.preventionForm.reset();  
      this.message = null;  
      this.dataSaved = false;  
    }

}
