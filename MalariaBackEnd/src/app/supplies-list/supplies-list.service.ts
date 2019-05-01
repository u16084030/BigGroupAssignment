import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { SuppliesList } from './supplies-list';

@Injectable({
  providedIn: 'root'
})
export class SuppliesListService {

  constructor(private http: HttpClient) { }

  getAllSuppliesLists()
  {
    return this.http.get('http://localhost:60090/api/SuppliesList/getAllSuppliesLists');
  }

  getSuppliesListById(supply:number)
  {
    return this.http.get('http://localhost:60090/api/SuppliesList/getSuppliesListById/'+supply);
  }

  addSuppliesList(supply:Object)
  {
    return this.http.post('http://localhost:60090/api/SuppliesList/addSuppliesList',supply);
  }

  updateSuppliesList(supply:Object)
  {
    return this.http.get('http://localhost:60090/api/SuppliesList/updateSuppliesList');
  }

  deleteSuppliesList(supply:number)
  {
    return this.http.post('http://localhost:60090/api/SuppliesList/deleteSuppliesList', supply);
  }
}

