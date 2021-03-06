import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './start/app.component';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './shared/app.routing';
import { HomeComponent } from  './home/home.component';
import { NavComponent } from './shared/navbar.component';
import { TopbarComponent } from './shared/topbar.component';
import { FooterComponent } from './shared/footer.component';
import { Lesson1Component } from './lesson1/lesson1.component';
import { Lesson2Component } from './lesson2/lesson2.component';
import { Lesson3Component } from './lesson3/lesson3.component';
import { Lesson4Component } from './lesson4/lesson4.component';
import { Lesson5Component } from './lesson5/lesson5.component';
import { Lesson6Component } from './lesson6/lesson6.component';
import { AboutComponent } from './about/about.component'; 
import { FlexLayoutModule } from '@angular/flex-layout';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        AppRoutingModule,
        FlexLayoutModule
    ],
    declarations: [
        AppComponent,
        HomeComponent,
        NavComponent,
        TopbarComponent,
        FooterComponent,
        Lesson1Component,
        Lesson2Component,
        Lesson3Component,
        Lesson4Component,
        Lesson5Component,
        Lesson6Component,
        AboutComponent
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