// this contains all Typescript code used in the app
//

import { Component } from '@angular/core'; // give me access to the angular compentent processing stuff
import { RouterOutlet } from '@angular/router'; // give me access to the angular router stuff

// identify the attributes/characteristics or the home/starting compentent
@Component({
  selector: 'app-root', // where to insert the code (the HTML) that angular generates
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',  // file with the HTML angular is to use for the Component
  styleUrl: './app.component.css'       // File with CSS to be applied to the HTML defined as the template
})
// exporet allow other processes outside of this Typescrip file (like angular) to allow access stuff in the typescript file 
export class AppComponent {
  title = 'myFirstAngularApp';    // name external processes can use to access this stuff
}
