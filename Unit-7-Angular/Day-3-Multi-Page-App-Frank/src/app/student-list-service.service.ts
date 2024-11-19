// store the student list data in memory for now
// 

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentListServiceService {

  theStudent : any[] = [];

  constructor() {
    // add some students
    this.theStudent.push({name: "Frank"})
    this.theStudent.push({"George"})
   }
    

  getStudent() {

  }

  addStudent() {

  }

}
