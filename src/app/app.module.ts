import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './start/app.component';

import { HttpClientModule } from '@angular/common/http';

import { HomeComponent } from  './home/home.component';
//import { NavComponent } from './shared/navbar.component';
//import { LogoComponent } from './shared/logo.component';
//import { ErrorComponent } from './error/error.component';
//import { AppRoutingModule } from './shared/app.routing';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule//,
        //AppRoutingModule,
    ],
    declarations: [
        AppComponent,
        HomeComponent
        //NavComponent,
        //LogoComponent,
        
        //ErrorComponent
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