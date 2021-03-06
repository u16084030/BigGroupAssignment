import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { OutbreakService } from '../outbreak/outbreak.service';  
import { Outbreak } from '../outbreak/outbreak';

@Component({
  selector: 'app-outbreak',
  templateUrl: './outbreak.component.html',
  styleUrls: ['./outbreak.component.scss']
})
export class OutbreakComponent implements OnInit {

  allOutbreaks: object;
  dataSaved = false;  
  outbreakForm: any;  
  outbreakIdUpdate = null;  
  message = null;

  constructor(private formbulider: FormBuilder, private outbreakService:OutbreakService) { }

  ngOnInit() {    
      this.outbreakForm = this.formbulider.group({  
      OutbreakID: ['', [Validators.required]],  
      AreaID: ['', [Validators.required]],  
      OutbreakDate: ['', [Validators.required]],
      OutbreakCity: ['', [Validators.required]],  
      NumberOfCasualties: ['', [Validators.required]],  
      OutbreakDescription: ['', [Validators.required]], 
    });
      this.loadAllOutbreaks();  
    }  
    loadAllOutbreaks() {  
      this.allOutbreaks = this.outbreakService.getAllOutbreaks();  
    } 
    
    onFormSubmit() {  
      this.dataSaved = false;  
      const outbreak = this.outbreakForm.value;  
      this.CreateOutbreak(outbreak);  
      this.outbreakForm.reset();  
    }  
    loadOutbreakToEdit(outbreak: Outbreak) {  
      this.outbreakService.updateOutbreak(outbreak).subscribe(()=> {  
        this.message = null;  
        this.dataSaved = false;    
        this.outbreakForm.controls['AreaID'].setValue(outbreak.AreaID);  
        this.outbreakForm.controls['OutbreakDate'].setValue(outbreak.OutbreakDate); 
        this.outbreakForm.controls['OutbreakCity'].setValue(outbreak.OutbreakCity);
        this.outbreakForm.controls['NumberOfCasualties'].setValue(outbreak.NumberOfCasualties);  
        this.outbreakForm.controls['OutbreakDescription'].setValue(outbreak.OutbreakDescription);  
      });  
    
    }  
    CreateOutbreak(outbreak: Outbreak) {  
      if (this.outbreakIdUpdate == null) {  
        this.outbreakService.addOutbreak(outbreak).subscribe(  
          () => {  
            this.dataSaved = true;  
            this.message = 'Record saved Successfully';  
            this.loadAllOutbreaks();  
            this.outbreakIdUpdate = null;  
            this.outbreakForm.reset();  
          }  
        );  
      } else {  
        outbreak.OutbreakID = this.outbreakIdUpdate;  
        this.outbreakService.updateOutbreak(outbreak).subscribe(() => {  
          this.dataSaved = true;  
          this.message = 'Record Updated Successfully';  
          this.loadAllOutbreaks();  
          this.outbreakIdUpdate = null;  
          this.outbreakForm.reset();  
        });  
      }  
    }   
    deleteOutbreak(outbreakId: number) {  
      if (confirm("Are you sure you want to delete this ?")) {   
      this.outbreakService.deleteOutbreakById(outbreakId).subscribe(() => {  
        this.dataSaved = true;  
        this.message = 'Record Deleted Succefully';  
        this.loadAllOutbreaks();  
        this.outbreakIdUpdate = null;  
        this.outbreakForm.reset();  
    
      });  
    }  
  }  
    resetForm() {  
      this.outbreakForm.reset();  
      this.message = null;  
      this.dataSaved = false;  
    }

}
