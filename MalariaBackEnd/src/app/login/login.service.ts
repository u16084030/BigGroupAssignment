import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
//import { Login } from './login';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }

  searchSpecialist(user, pass)
  { 
    return this.http.post('http://localhost:60090/api/Specialist/searchSpecialists', user, pass);
  }

}
