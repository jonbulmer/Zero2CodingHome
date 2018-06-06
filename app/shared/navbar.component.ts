import { Component } from '@angular/core';

@Component({
    selector: 'navi-bar',
    template:`
              <div class="top-bar">
               <div class="top-bar-title">Zeo2Coding</div>
                <div>
                 <ul class="menu">
                  <li class="nav-menu"><a href="./lesson1">Lesson 1</a></li>
                  <li class="nav-menu"><a href="./lesson2">Lesson 2</a></li>
                  <li class="nav-menu"><a href="./lesson3">Lesson 3</a></li>
                  <li class="nav-menu"><a href="./lesson4">Lesson 4</a></li>
                  <li class="nav-menu"><a href="./lesson5">Lesson 5</a></li>
                  <li class="nav-menu"><a href="./lesson6">Lesson 6</a></li> 
                  <li class="nav-menu"><a href="#">Home</a></li>
                 </ul>
                </div>
              </div> 
    `,
    styleUrls: ['./navbar.component.css']
})
export class NavComponent {}