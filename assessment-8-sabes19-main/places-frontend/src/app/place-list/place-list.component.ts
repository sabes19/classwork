import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { PlacesService } from '../services/places-service.service';
import { Place } from '@app/models/place';

@Component({
  selector: 'app-places-list',
  standalone: true,
  imports: [CommonModule, FormsModule, HttpClientModule],
  templateUrl: './place-list.component.html',
  styleUrls: ['./place-list.component.css'],
  providers: [PlacesService],
})
export class PlaceListComponent {
  places: Place[] = []; // Array of places
  newPlace: Place = { name: '', firstTime: false }; // New place object

  constructor(private placesService: PlacesService) {}

  ngOnInit(): void {
    this.fetchPlaces();
  }

  // Fetch places from the service
  fetchPlaces(): void {
    this.placesService.getPlaces().subscribe((data) => {
      this.places = data;
    });
  }

  // Add a new place
  addPlace(): void {
    if (this.newPlace.name.trim()) {
      this.placesService.addPlace(this.newPlace).subscribe(() => {
        this.fetchPlaces(); // Refresh the 
        this.newPlace = { name: '', firstTime: false }; // Reset form
      });
    }
  }
}


