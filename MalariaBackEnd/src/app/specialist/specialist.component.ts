import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { SpecialistService } from '../specialist/specialist.service';  
import { Specialist } from '../specialist/specialist'; 

@Component({
  selector: 'app-specialist',
  templateUrl: './specialist.component.html',
  styleUrls: ['./specialist.component.scss']
})
export class SpecialistComponent implements OnInit {

  allSpecialists: object;
  dataSaved = false;  
  specialistForm: any;  
  specialistIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private specialistService:SpecialistService) { }

  ngOnInit() {    
      this.specialistForm = this.formbulider.group({  
      DiseaseID: ['', [Validators.required]],  
      FirstName: ['', [Validators.required]],  
      LastName: ['', [Validators.required]],
      UserPassword: ['', [Validators.required]],  
      UserGUID: ['', [Validators.required]],  
      GUIDExpiry: ['', [Validators.required]],
      ContactNumber: ['', [Validators.required]],  
      Email: ['', [Validators.required]],  
      Qualification: ['', [Validators.required]],
      Hospital: ['', [Validators.required]], 
    });
      this.loadAllSpecialists();  
    }  
    loadAllSpecialists() {  
      this.allSpecialists = this.specialistService.getAllSpecialists();  
    } 
    
    onFormSubmit() {  
      this.dataSaved = false;  
      const specialist = this.specialistForm.value;  
      this.CreateSpecialist(specialist);  
      this.specialistForm.reset();  
    }  
    loadSpecialistToEdit(specialistId: number) {  
      this.specialistService.getSpecialistById(specialistId).subscribe(specialist=> {  
        this.message = null;  
        this.dataSaved = false;  
        this.specialistIdUpdate = 1;//Specialist.specialistID;  
        this.specialistForm.controls['CauseID'].setValue(1);//Specialist.DiseaseID);  
       this.specialistForm.controls['PreventDescription'].setValue("Fuck this");//Specialist.SpecialistDescription);  
        this.specialistForm.controls['PreventEffective'].setValue("HighAsFuck");//Specialist.SpecialistRanking);  
      });  
    
    }  
    CreateSpecialist(specialist: Specialist) {  
      if (this.specialistIdUpdate == null) {  
        this.specialistService.addSpecialist(specialist).subscribe(  
          () => {  
            this.dataSaved = true;  
            this.message = 'Record saved Successfully';  
            this.loadAllSpecialists();  
            this.specialistIdUpdate = null;  
            this.specialistForm.reset();  
          }  
        );  
      } else {  
        specialist.SpecialistID = this.specialistIdUpdate;  
        this.specialistService.updateSpecialist(specialist).subscribe(() => {  
          this.dataSaved = true;  
          this.message = 'Record Updated Successfully';  
          this.loadAllSpecialists();  
          this.specialistIdUpdate = null;  
          this.specialistForm.reset();  
        });  
      }  
    }   
    deleteSpecialist(specialistId: number) {  
      if (confirm("Are you sure you want to delete this ?")) {   
      this.specialistService.deleteSpecialistById(specialistId).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Deleted Succefully';  
        this.loadAllSpecialists();  
        this.specialistIdUpdate = null;  
        this.specialistForm.reset();  
    
      });  
    }  
  }  
    resetForm() {  
      this.specialistForm.reset();  
      this.message = null;  
      this.dataSaved = false;  
    }

}

