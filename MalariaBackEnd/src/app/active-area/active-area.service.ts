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

  getAreaById(area:number)
  {
    return this.http.get('http://localhost:60090/api/ActiveArea/getAreaById/'+area);
  }

  addActiveArea(area:Object)
  {
    return this.http.post('http://localhost:60090/api/ActiveArea/addActiveArea',area);
  }

  updateActiveArea(area:Object)
  {
    return this.http.post('http://localhost:60090/api/ActiveArea/updateActiveArea', area);
  }

  deleteActiveArea(area:number)
  {
    return this.http.delete('http://localhost:60090/api/ActiveArea/deleteActiveArea/'+area);
  }
}

