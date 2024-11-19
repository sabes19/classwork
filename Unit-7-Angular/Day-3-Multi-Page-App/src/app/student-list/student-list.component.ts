import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student-list.component.html',
  styleUrl: './student-list.component.css'
})

// the class contains the data and function used in the component
// it is exported so the data wont be shared with 
export class StudentListComponent {
//  define a list of students to be displayed
// it will be coded as an array of literals
// data will come from an external source, such as an API server

studentName = ["Ryan", "Josh", "Ashley", "Evan", "Ethan", "Kendall"]



}
