import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Disease } from './disease';

@Injectable({
  providedIn: 'root'
})
export class DiseaseService {

  constructor(private http: HttpClient) { }

  getAllDiseases()
  {
    return this.http.get('http://localhost:60090/api/Disease/getAllDiseases');
  }

  getDiseaseById(disease:number)
  {
    return this.http.get('http://localhost:60090/api/Disease/getDiseaseById/'+disease);
  }

  addDisease(disease:Object)
  {
    return this.http.post('http://localhost:60090/api/Disease/addDisease', disease);
  }

  updateDisease(disease:Object)
  {
    return this.http.post('http://localhost:60090/api/Disease/updateDisease', disease);
  }

  deleteDiseaseById(disease:number)
  {
    return this.http.delete('http://localhost:60090/api/Disease/deleteDiseaseById/'+disease);
  }
}
