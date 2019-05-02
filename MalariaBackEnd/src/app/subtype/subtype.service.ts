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

  getSubtypeById(subtype:number)
  {
    return this.http.get('http://localhost:60090/api/Subtype/getSubtypeById/'+subtype);
  }

  addSubtype(subtype:Object)
  {
    return this.http.post('http://localhost:60090/api/Subtype/addSubtype',subtype);
  }

  updateSubtype(subtype:Object)
  {
    return this.http.post('http://localhost:60090/api/Subtype/updateSubtype',subtype);
  }

  deleteSubtype(subtype:number)
  {
    return this.http.delete('http://localhost:60090/api/Subtype/deleteSubtype/'+subtype);
  }
}


