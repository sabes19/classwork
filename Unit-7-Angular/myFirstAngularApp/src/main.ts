// this starts the angular app
// when you use ng serve in gitbash it looks for main.ts to start the app
// This is where you put the home page (the starting component) for the app

import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';

// this is where we include the home component for t he app
// you specify the high level qualifiers for the application files
import { AppComponent } from './app/app.component';

// bootstrapApplication function is what the server calls to start the app
// The name of the import defined for the app passed as the first parameter
bootstrapApplication(AppComponent, appConfig)
  .catch((err) => console.error(err));

