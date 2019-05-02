import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { DiseaseService } from '../disease/disease.service';  
import { Disease } from '../disease/disease';

@Component({
  selector: 'app-disease',
  templateUrl: './disease.component.html',
  styleUrls: ['./disease.component.scss']
})
export class DiseaseComponent implements OnInit {

  allDiseases: object;
  dataSaved = false;  
  diseaseForm: any;  
  diseaseIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private diseaseService:DiseaseService) { }

  ngOnInit() {    
      this.diseaseForm = this.formbulider.group({  
      DiseaseID: ['', [Validators.required]],  
      CommonName: ['', [Validators.required]],  
      ScientificName: ['', [Validators.required]],
      Pathogen: ['', [Validators.required]],  
      IncubationPeriod: ['', [Validators.required]],  
      DiseaseDescription: ['', [Validators.required]], 
    });
      this.loadAllDiseases();  
    }  
    loadAllDiseases() {  
      this.allDiseases = this.diseaseService.getAllDiseases();  
    } 
    
    onFormSubmit() {  
      this.dataSaved = false;  
      const disease = this.diseaseForm.value;  
      this.CreateDisease(disease);  
      this.diseaseForm.reset();  
    }  
    loadDiseaseToEdit(disease: Disease) {  
      this.diseaseService.updateDisease(disease).subscribe(()=> {  
        this.message = null;  
        this.dataSaved = false;    
        this.diseaseForm.controls['CommonName'].setValue(disease.CommonName);  
        this.diseaseForm.controls['ScientificName'].setValue(disease.ScientificName);  
        this.diseaseForm.controls['Pathogen'].setValue(disease.Pathogen);
        this.diseaseForm.controls['IncubationPeriod'].setValue(disease.IncubationPeriod);  
        this.diseaseForm.controls['DiseaseDescription'].setValue(disease.DiseaseDescription);  
      });  
    
    }  
    CreateDisease(disease: Disease) {  
      if (this.diseaseIdUpdate == null) {  
        this.diseaseService.addDisease(disease).subscribe(  
          () => {  
            this.dataSaved = true;  
            this.message = 'Record saved Successfully';  
            this.loadAllDiseases();  
            this.diseaseIdUpdate = null;  
            this.diseaseForm.reset();  
          }  
        );  
      } else {  
        disease.DiseaseID = this.diseaseIdUpdate;  
        this.diseaseService.updateDisease(disease).subscribe(() => {  
          this.dataSaved = true;  
          this.message = 'Record Updated Successfully';  
          this.loadAllDiseases();  
          this.diseaseIdUpdate = null;  
          this.diseaseForm.reset();  
        });  
      }  
    }   
    deleteDisease(diseaseId: number) {  
      if (confirm("Are you sure you want to delete this ?")) {   
      this.diseaseService.deleteDiseaseById(diseaseId).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Deleted Succefully';  
        this.loadAllDiseases();  
        this.diseaseIdUpdate = null;  
        this.diseaseForm.reset();  
    
      });  
    }  
  }  
    resetForm() {  
      this.diseaseForm.reset();  
      this.message = null;  
      this.dataSaved = false;  
    }

}
