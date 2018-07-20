import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import{ HomeComponent } from '../home/home.component';
import { Lesson1Component } from '../lesson1/lesson1.component';
import { Lesson2Component } from '../lesson2/lesson2.component';
import { Lesson3Component } from '../lesson3/lesson3.component'; 
import { Lesson4Component } from '../lesson4/lesson4.component';
import { Lesson5Component } from '../lesson5/lesson5.component';
import { Lesson6Component } from '../lesson6/lesson6.component';

@NgModule({
    imports: [
        RouterModule.forRoot([
            { path: '' , component: HomeComponent},
            { path: 'home', component: HomeComponent },
            { path: 'lesson1', component: Lesson1Component},
            { path: 'lesson2', component: Lesson2Component},
            { path: 'lesson3', component: Lesson3Component },
            { path: 'lesson4', component: Lesson4Component },
            { path: 'lesson5', component: Lesson5Component },
            { path: 'lesson6', component: Lesson6Component }
        ])
    ],
    exports: [
        RouterModule
    ]   
})
export class AppRoutingModule {}