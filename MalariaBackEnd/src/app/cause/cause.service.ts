import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cause } from './cause';

@Injectable({
  providedIn: 'root'
})
export class CauseService {

  constructor(private http: HttpClient) { }

  getAllCauses()
  {
    return this.http.get('http://localhost:60090/api/Cause/getAllCauses');
  }

  getCauseById(cause:number)
  {
    return this.http.get('http://localhost:60090/api/Cause/getCauseById/'+cause);
  }

  addCause(cause:Object)
  {
    return this.http.post('http://localhost:60090/api/Cause/addCause', cause);
  }

  updateCause(cause:Object)
  {
    return this.http.get('http://localhost:60090/api/Cause/updateCause');
  }

  deleteCause(cause:number)
  {
    return this.http.post('http://localhost:60090/api/Cause/deleteCause', cause);
  }
}
