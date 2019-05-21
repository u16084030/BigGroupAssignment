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
}
