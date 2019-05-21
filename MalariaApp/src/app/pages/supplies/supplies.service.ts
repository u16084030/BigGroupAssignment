import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Supplies } from './supplies';

@Injectable({
  providedIn: 'root'
})
export class SuppliesService {

  constructor(private http: HttpClient) { }

  getAllSuppliesLists()
  {
    return this.http.get('http://localhost:60090/api/SuppliesList/getAllSuppliesLists');
  }
}
