// calls to an external API are done asynchronously
// the call to the API is sent to the Server and WE NEED TO WAIT FOR THE RESPONSE
//      (unlike calls to function in the same component)

// 'await' is used to for the call to the external API to be completed before the processing continues 

// when the call to the external API is made a promise object is issued 
//         which will suspend processesing until we return from the API

// A promise object is managed by "system"


import { CommonModule }  from '@angular/common';
import { Component, OnInit }     from '@angular/core';
import { MoviesService } from '../movies.service-api'; // access the MoviesServices service
import { RouterLink }    from '@angular/router';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.css'
})

// implements OnInit() indicate you want to add this to the OnInit() hook

// a hook is a place in the processing of a framework you want to add some additional processing
// here we are telling Angular we are adding some processing to its component initialization


export class MovieListComponent implements OnInit {

// This will hold the data for the movies to be displayed
// the data will come from a call to a service
// it starts out as an empty array
// use of any as a  data type coming from an an external source is common
// it allows any data type or format to be handled by the code   
//     var-name   : data-type
public moviesList : any[] = []; // This is an array of MoviesInfo objects

// empty constructoir to just have the service dependecy injected into the components
// it could have process but in this example there is other data 
                      
constructor(private movieService  : MoviesService ) {}

// instead of having the constructoir call the service to get the data
// we are using ngOnInit which is processing done by Angular before it runs the constructor
// This is usually where any process performing external API calls are used
// You want to get the data from t he external API before angular tries to do anything with it

// the async attribute tells angular it may be causing asynchrounous calls
// here we are addding the intilization of our data array to Angular's component initilization
async ngOnInit() {
  // we have 

  
  const theData  = await this.movieService.getMoviesList(); // Initialize our moviesList from service

  this.moviesList = theData

  console.table(this.movieService)
  
} 

}
