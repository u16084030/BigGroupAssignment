import { Component, OnInit } from '@angular/core';
import { Router, RouterEvent } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.page.html',
  styleUrls: ['./menu.page.scss'],
})
export class MenuPage implements OnInit {

  pages = [
    {
      title: 'Disease',
      url: '/menu/disease'
    },
    {
      title: 'Active Areas', 
      url: '/menu/active-area'
    },
    {
      title: 'Causes',
      url: '/menu/cause'
    },
    {
      title: 'Outbreaks',
      url: '/menu/outbreak'
    },
    {
      title: 'Preventions',
      url: '/menu/prevention'
    },
    {
      title: 'Subtypes',
      url: '/menu/subtype'
    },
    {
      title: 'Supplies',
      url: '/menu/supplies'
    },
    {
      title: 'Symptoms',
      url: '/menu/symptoms'
    },
    {
      title: 'Treatments',
      url: '/menu/treatment'
    },
  ];

  selectedPath = '';

  constructor(private router: Router) { 
    this.router.events.subscribe((event: RouterEvent) => {
      this.selectedPath = event.url;
    })
  }

  ngOnInit() {
  }

}
