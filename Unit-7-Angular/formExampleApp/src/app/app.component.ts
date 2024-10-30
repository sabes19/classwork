import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormExampleComponent } from "./components/form-example/form-example.component";

@Component({
  selector: 'app-root',
  standalone: true,
  // imports identifies external resources like component used in the app
  imports: [RouterOutlet, FormExampleComponent], // note tthe name has component in it
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

// export allows processes outside this component to access things defined in the comnponent
export class AppComponent {
  pageHeading = 'Welcome to ABC Coding'
}
