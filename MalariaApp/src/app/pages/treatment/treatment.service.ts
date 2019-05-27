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

  searchTreatments(temp)
  {
    return this.http.post('http://localhost:60090/api/Treatment/searchTreatments/'+temp, temp);
  }
}
