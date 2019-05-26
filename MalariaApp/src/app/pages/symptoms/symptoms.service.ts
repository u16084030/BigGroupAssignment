import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Symptoms } from './symptoms';

@Injectable({
  providedIn: 'root'
})
export class SymptomsService {

  constructor(private http: HttpClient) { }

  getAllSymptoms()
  {
    return this.http.get('http://localhost:60090/api/Symptom/getAllSymptoms');
  }
}
