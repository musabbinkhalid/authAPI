import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { loginComponent } from './Components'
import { homeComponent } from './Components/homeComponent';
import { AuthGuard } from './_Helpers';
const routes: Routes = [
  {
    path: '',
    component: homeComponent,
    canActivate: [AuthGuard]
  },
  {
    path: 'login',
    component: loginComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
