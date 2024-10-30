import { Component } from '@angular/core';

@Component({
  selector: 'app-form-example',
  standalone: true,
  imports: [],
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
export class FormExampleComponent {

onSubmit() {    // handle the submit button click on the form
  console.log("Ok...you hit submit")
}
}
