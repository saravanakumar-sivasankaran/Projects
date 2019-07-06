import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Http, HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import {HomeComponent} from './Home/Home.component';
import {ServiceAppComponent} from './ServiceApp/ServiceApp.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ServiceAppComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    RouterModule.forRoot([
      { path: 'service', component: ServiceAppComponent},
      { path: 'home', component: HomeComponent},
      { path: '', component: HomeComponent}
    ])
  ],
  providers: [
  ],
  bootstrap: [AppComponent],
  exports:[RouterModule]
})
export class AppModule { }
