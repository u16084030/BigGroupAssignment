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

  searchPreventions(temp)
  {
    return this.http.post('http://localhost:60090/api/Prevention/searchPreventions/'+temp, temp);
  }
}
