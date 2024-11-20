// this file identifies major features of angular you will be using

import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
// HTTP is the protocal for interfacing with external servers
//
// HTTP: GET - retrieve data from server
//       POST   - add data to a server
//       DELETE - re,mpve data from a server
//       PUT  - i[data data onm a server
// gain access to angular http suppoort via httpClient

// CRUD
// Create
// Read
// Update
// Delete




import { provideHttpClient } from '@angular/common/http';

import { routes } from './app.routes';

export const appConfig: ApplicationConfig = {
  // the providers attribute is
  providers: [provideRouter(routes), ((provideHttpClient()))]
};