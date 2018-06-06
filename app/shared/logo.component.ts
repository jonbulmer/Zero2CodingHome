import { Component } from '@angular/core';

@Component({
    selector: 'logo-bar',
    template: `<h1>{{title}}</h1>
               <div class="row ">
                <img  src="/src/app/shared/images/deLogo.jpg">
               </div>
    ` 
})
export class LogoComponent {
    title = 'Zero2Coding';
}