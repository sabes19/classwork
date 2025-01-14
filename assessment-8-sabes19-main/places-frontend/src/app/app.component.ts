import { bootstrapApplication } from '@angular/platform-browser';
import { provideHttpClient } from '@angular/common/http';
import { provideRouter, Routes } from '@angular/router';
import { importProvidersFrom } from '@angular/core';
import { PlaceListComponent } from './place-list/place-list.component';
import { Component } from '@angular/core';






@Component({
  selector: 'app-root',
  standalone: true,
  imports: [PlaceListComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
   
})
export class AppComponent {
  title = 'places-frontend';
} 