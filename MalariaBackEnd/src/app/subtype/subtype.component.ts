import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { SubtypeService } from '../subtype/subtype.service';  
import { Subtype } from '../subtype/subtype'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-subtype',
  templateUrl: './subtype.component.html',
  styleUrls: ['./subtype.component.scss']
})
export class SubtypeComponent implements OnInit {

  allSubtypes: object;
  dataSaved = false;  
  subtypeForm: any;  
  subtypeIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private subtypeService:SubtypeService) { }

  ngOnInit() {  
         
    this.subtypeForm = this.formbulider.group({  
    DiseaseID: ['', [Validators.required]],  
    SubtypeName: ['', [Validators.required]],  
    Strain: ['', [Validators.required]], 
    SubtypeDescription: ['', [Validators.required]],  
    
  });
    this.loadAllSubtypes();  
  } 

  loadAllSubtypes() {  
    this.allSubtypes = this.subtypeService.getAllSubtypes();  
  } 

  onFormSubmit() {  
    this.dataSaved = false;  
    const subtype = this.subtypeForm.value; 
    this.CreateSubtype(subtype);  
    this.subtypeForm.reset();  
  }  
  loadSubtypeToEdit(subtypeId: number) {  
    this.subtypeService.getSubtypeById(subtypeId).subscribe(subtype=> {  
      this.message = null;  
      this.dataSaved = false;  
      this.subtypeIdUpdate = 1;//cause.CauseID;  
      this.subtypeForm.controls['DiseaseID'].setValue(1);//cause.DiseaseID);  
      this.subtypeForm.controls['SubtypeName'].setValue("Fuck this");//cause.CauseDescription);  
      this.subtypeForm.controls['Strain'].setValue("HighAsFuck");//cause.CauseRanking); 
      this.subtypeForm.controls['SubtypeDescription'].setValue("HighAsFuck");//cause.CauseRanking);  
    });  
  
  }  
  CreateSubtype(subtype: Subtype) {  
    if (this.subtypeIdUpdate == null) {  
      this.subtypeService.addSubtype(subtype).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.message = 'Record saved Successfully';  
          this.loadAllSubtypes();  
          this.subtypeIdUpdate = null;  
          this.subtypeForm.reset();  
        }  
      );  
    } else {  
      subtype.SubtypeID = this.subtypeIdUpdate;  
      this.subtypeService.updateSubtype(subtype).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Updated Successfully';  
        this.loadAllSubtypes();  
        this.subtypeIdUpdate = null;  
        this.subtypeForm.reset();  
      });  
    }  
  }   
  deleteSubtype(subtypeId: number) {  
    if (confirm("Are you sure you want to delete this ?")) {   
    this.subtypeService.deleteSubtype(subtypeId).subscribe(() => {  
      this.dataSaved = true;  
      this.message = 'Record Deleted Succefully';  
      this.loadAllSubtypes();  
      this.subtypeIdUpdate = null;  
      this.subtypeForm.reset();  
  
    });  
  }  
}  
  resetForm() {  
    this.subtypeForm.reset();  
    this.message = null;  
    this.dataSaved = false;  
  }
}



