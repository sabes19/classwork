// this file directs angular to the component assigned to a path specified as a link

import { Routes }        from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SampleFormComponent } from './sample-form/sample-form.component';
import { StateSealsComponent } from './state-seals/state-seals.component';
import { StudentListComponent } from './student-list/student-list.component';

export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' },        // the "/home" path references the home component
    {path: 'home',          component: HomeComponent},
    {path: 'contactInfo',   component: SampleFormComponent },
    {path: 'showSeals',     component: StateSealsComponent }
    {path: 'students',      component: StudentListComponent }
];
