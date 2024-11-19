// this is where the code for processing in the service goes
// data and functions

import { Injectable }  from '@angular/core';
import { studentData } from './students';     // gives access to studentData interface

@Injectable({
  providedIn: 'root'
})
export class MyServiceService {

  constructor() { }
}
