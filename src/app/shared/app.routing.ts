import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import{ HomeComponent } from '../home/home.component';
import { Lesson1Component } from '../lesson1/lesson1.component';
import { Lesson2Component } from '../lesson2/lesson2.component';

@NgModule({
    imports: [
        RouterModule.forRoot([
            { path: '' , component: HomeComponent},
            { path: 'home', component: HomeComponent },
            { path: 'lesson1', component: Lesson1Component},
            { path: 'lesson2', component: Lesson2Component}
        ])
    ],
    exports: [
        RouterModule
    ]   
})
export class AppRoutingModule {}