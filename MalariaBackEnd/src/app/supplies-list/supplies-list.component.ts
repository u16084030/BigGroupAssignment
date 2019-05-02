import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { SuppliesListService } from '../supplies-list/supplies-list.service';  
import { SuppliesList } from '../supplies-list/supplies-list'; 
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'app-supplies-list',
  templateUrl: './supplies-list.component.html',
  styleUrls: ['./supplies-list.component.scss']
})
export class SuppliesListComponent implements OnInit {

  allSupplies: object;
  dataSaved = false;  
  suppliesForm: any;  
  supplyIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private suppliesListService:SuppliesListService) { }

  ngOnInit() {  
         
    this.suppliesForm = this.formbulider.group({  
    SupplyID: ['', [Validators.required]],  
    PreventID: ['', [Validators.required]],  
    SupplyName: ['', [Validators.required]], 
    AvailableAt: ['', [Validators.required]],
  });
    this.loadAllSupplies();  
  }  
  loadAllSupplies() {  
    this.allSupplies = this.suppliesListService.getAllSuppliesLists();  
  } 

  onFormSubmit() {  
    this.dataSaved = false;  
    const supply = this.suppliesForm.value; 
    this.CreateSupply(supply);  
    this.suppliesForm.reset();  
  }  
  loadSupplyToEdit(supplyId: number) {  
    this.suppliesListService.getSuppliesListById(supplyId).subscribe(supply=> {  
      this.message = null;  
      this.dataSaved = false;  
      this.supplyIdUpdate = 1;//supply.supplyID;  
      this.suppliesForm.controls['SupplyName'].setValue(1);//supply.DiseaseID);  
      this.suppliesForm.controls['AvailableAt'].setValue("Fuck this");//supply.supplyDescription);   
    });  
  
  }  
  CreateSupply(supply: SuppliesList) {  
    if (this.supplyIdUpdate == null) {  
      this.suppliesListService.addSuppliesList(supply).subscribe(  
        () => {  
          this.dataSaved = true;  
          this.message = 'Record saved Successfully';  
          this.loadAllSupplies();  
          this.supplyIdUpdate = null;  
          this.suppliesForm.reset();  
        }  
      );  
    } else {  
      supply.SupplyID = this.supplyIdUpdate;  
      this.suppliesListService.updateSuppliesList(supply).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Updated Successfully';  
        this.loadAllSupplies();  
        this.supplyIdUpdate = null;  
        this.suppliesForm.reset();  
      });  
    }  
  }   
  deleteSupply(supplyId: number) {  
    if (confirm("Are you sure you want to delete this ?")) {   
    this.suppliesListService.deleteSuppliesList(supplyId).subscribe(() => {  
      this.dataSaved = true;  
      this.message = 'Record Deleted Succefully';  
      this.loadAllSupplies();  
      this.supplyIdUpdate = null;  
      this.suppliesForm.reset();  
  
    });  
  }  
}  
  resetForm() {  
    this.suppliesForm.reset();  
    this.message = null;  
    this.dataSaved = false;  
  }
}



