import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { CauseService } from '../cause/cause.service';  
import { Cause } from '../cause/cause'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-cause',
  templateUrl: './cause.component.html',
  styleUrls: ['./cause.component.scss']
})
export class CauseComponent implements OnInit {

  allCauses: object;
  dataSaved = false;  
  causeForm: any;  
  causeIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private causeService:CauseService) { }

  ngOnInit() {  
         
      this.causeForm = this.formbulider.group({  
      DiseaseID: ['', [Validators.required]],  
      CauseDescription: ['', [Validators.required]],  
      CauseRanking: ['', [Validators.required]], 
    });
      this.loadAllCauses();  
    }  
    loadAllCauses() {  
      this.allCauses = this.causeService.getAllCauses();  
    } 
    
    onFormSubmit() {  
      this.dataSaved = false;  
      const cause = this.causeForm.value; 
      this.CreateCause(cause);  
      this.causeForm.reset();  
    }  
    loadCauseToEdit(cause: Cause) {  
      this.causeService.updateCause(cause).subscribe(()=> {  
        this.message = null;  
        this.dataSaved = false;  
        this.causeIdUpdate = cause.CauseID;  
        this.causeForm.controls['DiseaseID'].setValue(cause.DiseaseID);  
       this.causeForm.controls['CauseDescription'].setValue(cause.CauseDescription);  
        this.causeForm.controls['CauseRanking'].setValue(cause.CauseRanking);  
      });  
    
    }  
    CreateCause(cause: Cause) {  
      if (this.causeIdUpdate == null) {  
        this.causeService.addCause(cause).subscribe(  
          () => {  
            this.dataSaved = true;  
            this.message = 'Record saved Successfully';  
            this.loadAllCauses();  
            this.causeIdUpdate = null;  
            this.causeForm.reset();  
          }  
        );  
      } else {  
        cause.CauseID = this.causeIdUpdate;  
        this.causeService.updateCause(cause).subscribe(() => {  
          this.dataSaved = true;  
          this.message = 'Record Updated Successfully';  
          this.loadAllCauses();  
          this.causeIdUpdate = null;  
          this.causeForm.reset();  
        });  
      }  
    }   
    deleteCause(causeId: number) {  
      if (confirm("Are you sure you want to delete this ?")) {   
      this.causeService.deleteCause(causeId).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Deleted Succefully';  
        this.loadAllCauses();  
        this.causeIdUpdate = null;  
        this.causeForm.reset();  
    
      });  
    }  
  }  
    resetForm() {  
      this.causeForm.reset();  
      this.message = null;  
      this.dataSaved = false;  
    }
  }
