import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './start/app.component';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './shared/app.routing';
import { HomeComponent } from  './home/home.component';
import { NavComponent } from './shared/navbar.component';
import { Lesson1Component } from './lesson1/lesson1.component';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        AppRoutingModule
    ],
    declarations: [
        AppComponent,
        HomeComponent,
        NavComponent,
        Lesson1Component
    ],
    providers: [
       // {
       //     provide: APP_INITIALIZER,
       //     useFactory: loadConfig,
       //     multi: true
       // }
    ],
    bootstrap: [ AppComponent ],
})

export class AppModule { }