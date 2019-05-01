import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Prevention } from './prevention';

@Injectable({
  providedIn: 'root'
})
export class PreventionService {

  constructor(private http: HttpClient) { }

  getAllPreventions()
  {
    return this.http.get('http://localhost:60090/api/Prevention/getAllPreventions');
  }

  getPreventionById(prevention:number)
  {
    return this.http.get('http://localhost:60090/api/Prevention/getPreventionById/'+prevention);
  }

  addPrevention(prevention:Object)
  {
    return this.http.post('http://localhost:60090/api/Prevention/addPrevention', prevention);
  }

  updatePrevention(prevention:Object)
  {
    return this.http.get('http://localhost:60090/api/Prevention/updatePrevention');
  }

  deletePreventionById(prevention:number)
  {
    return this.http.post('http://localhost:60090/api/Prevention/deletePreventionById', prevention);
  }
}
