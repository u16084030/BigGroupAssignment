import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';  
import { Observable } from 'rxjs';  
import { LoginService } from '../login/login.service';  
//import { Login } from '../login/login'; 
import { forEach } from '@angular/router/src/utils/collection';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {

  Username: string;
  Password: string;
  t: object;
  temp: boolean;

  constructor(private formbulider: FormBuilder, private loginService:LoginService, private router:Router) {
  }

  ngOnInit() {
  }

  login(){
    this.t = this.loginService.searchSpecialist(this.Username, this.Password);
    console.log(this.t);
    if(this.t)
    {
        this.router.navigate(['disease']);
    }
  }

}
