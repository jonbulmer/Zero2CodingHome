import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './start/app.component';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './shared/app.routing';
import { HomeComponent } from  './home/home.component';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        AppRoutingModule
    ],
    declarations: [
        AppComponent,
        HomeComponent
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