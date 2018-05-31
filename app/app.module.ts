import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './start/app.component';

import { HttpClientModule } from '@angular/common/http';

//import { ForbiddenComponent } from './admin/forbidden/forbidden.component';
//import { UnauthorizedComponent } from './admin/unauthorized/unauthorized.component';
//import { SecureFilesComponent } from './admin/securefile/securefiles.component';
import { HomeComponent } from  './home/home.component';
import { NavComponent } from './shared/navbar.component';
import { LogoComponent } from './shared/logo.component';
import { ErrorComponent } from './error/error.component';
import { AppRoutingModule } from './shared/app.routing';
import { CompanyListComponent } from './companies/company-list.component';
import { AdminModule } from './admin/admin.module';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        AdminModule,
        AppRoutingModule,
    ],
    declarations: [
        AppComponent,
        //ForbiddenComponent,
        //UnauthorizedComponent,
        //SecureFilesComponent,
        NavComponent,
        LogoComponent,
        HomeComponent,
        ErrorComponent,
        CompanyListComponent
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