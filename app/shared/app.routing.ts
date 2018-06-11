import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import{ HomeComponent } from '../home/home.component';
import{ ErrorComponent } from '../error/error.component';
import { Lesson1Component } from "../lesson1/lesson1.component";
import { CompanyModule } from '../companies/company.module' ;

@NgModule({
    imports: [
        RouterModule.forRoot([
            { path: '', component: HomeComponent },
            { path: '**' , component: ErrorComponent}
        ]),
        CompanyModule
    ],
    exports: [
        RouterModule
    ]   
})
export class AppRoutingModule {}