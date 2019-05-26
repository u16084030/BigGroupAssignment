import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Specialist } from './specialist';

@Injectable({
  providedIn: 'root'
})
export class SpecialistService {

  constructor(private http: HttpClient) { }

  getAllSpecialists()
  {
    return this.http.get('http://localhost:60090/api/Specialist/getAllSpecialists');
  }

  getSpecialistById(specialist:number)
  {
    return this.http.get('http://localhost:60090/api/Specialist/getSpecialistById/'+specialist);
  }

  addSpecialist(specialist:Object)
  {
    return this.http.post('http://localhost:60090/api/Specialist/addSpecialist', specialist);
  }

  updateSpecialist(specialist:Object)
  {
    return this.http.post('http://localhost:60090/api/Specialist/updateSpecialist',specialist);
  }

  deleteSpecialist(specialist:number)
  {
    return this.http.delete('http://localhost:60090/api/Specialist/deleteSpecialist/'+specialist);
  }
}
