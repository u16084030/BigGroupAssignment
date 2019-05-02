import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { SymptonService } from '../sympton/sympton.service';  
import { Sympton } from '../sympton/sympton'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-sympton',
  templateUrl: './sympton.component.html',
  styleUrls: ['./sympton.component.scss']
})
export class SymptonComponent implements OnInit {

  allSymptons: object;
  dataSaved = false;  
  symptonForm: any;  
  symptonIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private symptonService:SymptonService) { }

  ngOnInit() {  
         
    this.symptonForm = this.formbulider.group({ 
    SymptomID: ['', [Validators.required]], 
    DiseaseID: ['', [Validators.required]],  
    SymptomName: ['', [Validators.required]],  
    SymptomDescription: ['', [Validators.required]],
    SymptomSeverity: ['', [Validators.required]],  
    SymptomAppears: ['', [Validators.required]], 
    DefiningCharacteristic: ['', [Validators.required]],
  });
    this.loadAllSymptons();  
  }  
  loadAllSymptons() {  
    this.allSymptons = this.symptonService.getAllSymptoms();  
  } 

  onFormSubmit() {  
    this.dataSaved = false;  
    const sympton = this.symptonForm.value; 
    this.CreateSympton(sympton);  
    this.symptonForm.reset();  
  }  
  loadSymptonToEdit(sympton: Sympton) {  
    this.symptonService.updateSymptom(sympton).subscribe(()=> {  
      this.message = null;  
      this.dataSaved = false;  
      this.symptonIdUpdate = sympton.SymptomID; 
      this.symptonForm.controls['DiseaseID'].setValue(sympton.DiseaseID); 
      this.symptonForm.controls['SymptomName'].setValue(sympton.SymptomName);  
      this.symptonForm.controls['SymptomDescription'].setValue(sympton.SymptomDescription);  
      this.symptonForm.controls['SymptomSeverity'].setValue(sympton.SymptomSeverity);
      this.symptonForm.controls['SymptomAppears'].setValue(sympton.SymptomAppears);
      this.symptonForm.controls['DefiningCharacteristic'].setValue(sympton.DefiningCharacteristic);  
    });  
  
  }  
  CreateSympton(sympton: Sympton) {  
    if (this.symptonIdUpdate == null) {  
      this.symptonService.addSymptom(sympton).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.message = 'Record saved Successfully';  
          this.loadAllSymptons();  
          this.symptonIdUpdate = null;  
          this.symptonForm.reset();  
        }  
      );  
    } else {  
      sympton.SymptomID = this.symptonIdUpdate;  
      this.symptonService.updateSymptom(sympton).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Updated Successfully';  
        this.loadAllSymptons();  
        this.symptonIdUpdate = null;  
        this.symptonForm.reset();  
      });  
    }  
  }   
  deleteSympton(symptonId: number) {  
    if (confirm("Are you sure you want to delete this ?")) {   
    this.symptonService.deleteSymptom(symptonId).subscribe(() => {  
      this.dataSaved = true;  
      this.message = 'Record Deleted Succefully';  
      this.loadAllSymptons();  
      this.symptonIdUpdate = null;  
      this.symptonForm.reset();  
  
    });  
  }  
}  
  resetForm() {  
    this.symptonForm.reset();  
    this.message = null;  
    this.dataSaved = false;  
  }
}


