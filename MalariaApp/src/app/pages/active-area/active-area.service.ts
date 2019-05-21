import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActiveArea } from './active-area';

@Injectable({
  providedIn: 'root'
})
export class ActiveAreaService {

  constructor(private http: HttpClient) { }

  getAllActiveAreas()
  {
    return this.http.get('http://localhost:60090/api/ActiveArea/getAllActiveAreas');
  }
}
