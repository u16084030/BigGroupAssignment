import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Treatment } from './treatment';

@Injectable({
  providedIn: 'root'
})
export class TreatmentService {

  constructor(private http: HttpClient) { }

  getAllTreatments()
  {
    return this.http.get('http://localhost:60090/api/Treatment/getAllTreatments');
  }

  getTreatmentById(treatment:number)
  {
    return this.http.get('http://localhost:60090/api/Treatment/getTreatmentById/'+treatment);
  }

  addTreatment(treatment:Object)
  {
    return this.http.post('http://localhost:60090/api/Treatment/addTreatment',treatment);
  }

  updateTreatment(treatment:Object)
  {
    return this.http.post('http://localhost:60090/api/Treatment/updateTreatment',treatment);
  }

  deleteTreatment(treatment:number)
  {
    return this.http.delete('http://localhost:60090/api/Treatment/deleteTreatment/'+treatment);
  }
}

