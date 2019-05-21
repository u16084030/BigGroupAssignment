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
}
