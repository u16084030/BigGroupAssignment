import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Sympton } from './sympton';

@Injectable({
  providedIn: 'root'
})
export class SymptonService {

  constructor(private http: HttpClient) { }

  getAllSymptoms()
  {
    return this.http.get('http://localhost:60090/api/Symptom/getAllSymptoms');
  }

  getSymptomById(sympton:number)
  {
    return this.http.get('http://localhost:60090/api/Symptom/getSymptomById/'+sympton);
  }

  addSymptom(sympton:Object)
  {
    return this.http.post('http://localhost:60090/api/Symptom/addSymptom',sympton);
  }

  updateSymptom(sympton:Object)
  {
    return this.http.post('http://localhost:60090/api/Symptom/updateSymptom', sympton);
  }

  deleteSymptom(sympton:number)
  {
    return this.http.delete('http://localhost:60090/api/Symptom/deleteSymptom/'+sympton);
  }
}

