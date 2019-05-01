import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Outbreak } from './outbreak';

@Injectable({
  providedIn: 'root'
})
export class OutbreakService {

  constructor(private http: HttpClient) { }

  getAllOutbreaks()
  {
    return this.http.get('http://localhost:60090/api/Outbreak/getAllOutbreaks');
  }

  getOutbreakById(outbreak:number)
  {
    return this.http.get('http://localhost:60090/api/Outbreak/getOutbreakById/'+outbreak);
  }

  addOutbreak(outbreak:Object)
  {
    return this.http.post('http://localhost:60090/api/Outbreak/addOutbreak', outbreak);
  }

  updateOutbreak(outbreak:Object)
  {
    return this.http.get('http://localhost:60090/api/Outbreak/updateOutbreak');
  }

  deleteOutbreakById(outbreak:number)
  {
    return this.http.post('http://localhost:60090/api/Outbreak/deleteOutbreakById/', outbreak);
  }
}
