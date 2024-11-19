/***************************************************************
 This is service

 A service is a set of processing to facilitate the retrieval
 and storage of data - typically in a persistent source (saved)

 May do other processing as well

 The data from this service is stored on an external n API

*******************************************************************/

import { Injectable}   from '@angular/core'; // Access Angular Dependency Injection

import { HttpClient, HttpHeaders } from '@angular/common/http';
// get access to the angular HTTP request support
// HTTPClient will handle all the HTTP requests that are made
// HTTPHeader will handle all the header info an HTTP request might need
//                 (usually only POST and PUT requests need headers) 



@Injectable({           // tells angular this service is dependable injectable 
  providedIn: 'root'
})

export class MoviesService {

  // A module contains data and methods/functions for processing that data

  // Source of data for calls to retrieve the data - initialized in the code
  private listOfMovies : any[] = []  // An array of objects from the API

  private movieInfoApi : string = "https://65f1fd0b034bdbecc7642d17.mockapi.io/api/v1/movies"
    // this is a variable to hold the external API URL


  constructor(private http:HttpClient) {} 
    // constructor is run after Angular initialization
    // it should initilize data for the service
    // this one will get the initial copy of the data from the external API
    // because this is an async function it returns a Promise with any data

    // functionName(parms) : what-it-returns
    async  getMoviesList() : Promise<any[]> {  
      // this function returns an array of objects
      // call the internal function getMoviesList() asynchrounously to get the data
      // it returns the Promise from the async call to the API with the associated data        

      // await - wait for the async call to complete before continuing
      // this.http.get - does the HTTP GET to the URL specified 
      // this.movieInfoAPI - the variable with the URL for the API
      // 

      const theMovies: any[] = await this.http.get<any>(this.movieInfoApi).toPromise()
      
      this.listOfMovies = theMovies  // assign the data from the API call to our array
      
      
      return this.listOfMovies // return our array of movies
      }


      
        // This method will receive a MoviesInfo object and add it to our data source (listOfMovies)
        // an  HTTP POST is used to add  data to an API
        // the HTTP POST needs to tell the server what kind of data is being for addition to data source
        // HTTP Headers provide info about the reuest to the server such as: 
        //        1. Security tokens to identify who you are
        //        2. the type of data being sent with the request
        //        3. admin info about the request
        // We need to create a header to at least tell the server what type of data we are sending it.
        //        (Usually JSON, but it could be plain text, XML, image, and others ) 


      async addMovies(newMovie : any) : Promise<any> {      
      //  console.table(newMovie)          // optional - verify new movie data
      
      // create a header to tell the server we are sending it JSON data with the request
      // 'application/json' is how you indicate JSON data

      // the ANgular HTTPClient takes care of converting the data for you if necessary
      // 'Content-Type' is the attribute where type of incoming data is specified
      // use new HttpHeaders to create a JSON object with the attributes you want to send


      const headers = new HttpHeaders ({
                                        'Content-Type' : 'application/json'
                                       });
        // use http.post(API-URL, data-to-send, {header-object}).toPromise()                                       
       return this.http.post(this.movieInfoApi, newMovie, {headers}).toPromise();
             }
  } 
