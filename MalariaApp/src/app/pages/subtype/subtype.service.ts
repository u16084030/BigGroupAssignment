import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Subtype } from './subtype';

@Injectable({
  providedIn: 'root'
})
export class SubtypeService {

  constructor(private http: HttpClient) { }

  getAllSubtypes()
  {
    return this.http.get('http://localhost:60090/api/Subtype/getAllSubtypes');
  }
}
