import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { TreatmentService } from '../treatment/treatment.service';  
import { Treatment } from '../treatment/treatment'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-treatment',
  templateUrl: './treatment.component.html',
  styleUrls: ['./treatment.component.scss']
})
export class TreatmentComponent implements OnInit {

  allTreatments: object;
  dataSaved = false;  
  treatmentForm: any;  
  treatmentIdUpdate = null;  
  message = null;


  constructor(private formbulider: FormBuilder, private treatmentService:TreatmentService) { }

  ngOnInit() {  
         
    this.treatmentForm = this.formbulider.group({  
    DiseaseID: ['', [Validators.required]],  
    TreatmentName: ['', [Validators.required]],  
    TreatmentDescription: ['', [Validators.required]], 
    AvailableAt: ['', [Validators.required]], 
    TreatmentDuration: ['', [Validators.required]],  
    AfterCare: ['', [Validators.required]],  
    TreatmentEffective: ['', [Validators.required]], 
    Aftermath: ['', [Validators.required]], 
  });
    this.loadAllTreatments();  
  }  
  loadAllTreatments() {  
    this.allTreatments = this.treatmentService.getAllTreatments();  
  } 

  onFormSubmit() {  
    this.dataSaved = false;  
    const treatment = this.treatmentForm.value; 
    this.CreateTreatment(treatment);  
    this.treatmentForm.reset();  
  }  

  loadTreatmentToEdit(treatment: Treatment) {  
    this.treatmentService.updateTreatment(treatment).subscribe(()=> {  
      this.message = null;  
      this.dataSaved = false;  
      this.treatmentIdUpdate = treatment.TreatmentID;  
      this.treatmentForm.controls['DiseaseID'].setValue(treatment.DiseaseID);  
      this.treatmentForm.controls['TreatmentName'].setValue(treatment.TreatmentName);  
      this.treatmentForm.controls['TreatmentDescription'].setValue(treatment.TreatmentDescription);  
      this.treatmentForm.controls['AvailableAt'].setValue(treatment.AvailableAt);  
      this.treatmentForm.controls['TreatmentDuration'].setValue(treatment.TreatmentDuration);  
      this.treatmentForm.controls['AfterCare'].setValue(treatment.AfterCare); 
      this.treatmentForm.controls['TreatmentEffective'].setValue(treatment.TreatmentEffective);  
      this.treatmentForm.controls['Aftermath'].setValue(treatment.Aftermath); 
    });  
  
  }  

  CreateTreatment(treatment: Treatment) {  
    if (this.treatmentIdUpdate == null) {  
      this.treatmentService.addTreatment(treatment).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.message = 'Record saved Successfully';  
          this.loadAllTreatments();  
          this.treatmentIdUpdate = null;  
          this.treatmentForm.reset();  
        }  
      );  
    } else {  
      treatment.TreatmentID = this.treatmentIdUpdate;  
      this.treatmentService.updateTreatment(treatment).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Updated Successfully';  
        this.loadAllTreatments();  
        this.treatmentIdUpdate = null;  
        this.treatmentForm.reset();  
      });  
    }  
  }   
  deleteTreatment(treatmentId: number) {  
    if (confirm("Are you sure you want to delete this ?")) {   
    this.treatmentService.deleteTreatment(treatmentId).subscribe(() => {  
      this.dataSaved = true;  
      this.message = 'Record Deleted Succefully';  
      this.loadAllTreatments();  
      this.treatmentIdUpdate = null;  
      this.treatmentForm.reset();  
  
    });  
  }  
}  
  resetForm() {  
    this.treatmentForm.reset();  
    this.message = null;  
    this.dataSaved = false;  
  }
}


